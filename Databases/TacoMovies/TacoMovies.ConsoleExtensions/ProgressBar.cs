﻿using System;
using System.Text;
using System.Threading;
using TacoMovies.ConsoleExtensions.Contracts;

namespace TacoMovies.ConsoleExtensions
{
    public class ProgressBar : IDisposable, IProgress<double>, IProgressBar
    {
        private const int blockCount = 10;
        private const string animation = @"|/-\";
        private readonly TimeSpan animationInterval = TimeSpan.FromSeconds(1.0 / 8);

        private readonly Timer timer;
        private int animationIndex;

        private double currentProgress;
        private string currentText = string.Empty;
        private bool disposed;

        public ProgressBar()
        {
            this.timer = new Timer(this.TimerHandler);

            // A progress bar is only for temporary display in a console window.
            // If the console output is redirected to a file, draw nothing.
            // Otherwise, we'll end up with a lot of garbage in the target file.
            if (!Console.IsOutputRedirected)
            {
                this.ResetTimer();
            }
        }

        public void Dispose()
        {
            lock (this.timer)
            {
                this.disposed = true;
                this.UpdateText(string.Empty);
            }
        }

        public void Report(double value)
        {
            // Make sure value is in [0..1] range
            value = Math.Max(0, Math.Min(1, value));
            Interlocked.Exchange(ref this.currentProgress, value);
        }

        private void TimerHandler(object state)
        {
            lock (this.timer)
            {
                if (this.disposed)
                {
                    return;
                }

                var progressBlockCount = (int) (this.currentProgress * blockCount);
                var percent = (int) (this.currentProgress * 100);
                var text = string.Format("[{0}{1}] {2,3}% {3}",
                    new string('#', progressBlockCount), new string('-', blockCount - progressBlockCount),
                    percent,
                    animation[this.animationIndex++ % animation.Length]);
                this.UpdateText(text);

                this.ResetTimer();
            }
        }

        private void UpdateText(string text)
        {
            // Get length of common portion
            var commonPrefixLength = 0;
            var commonLength = Math.Min(this.currentText.Length, text.Length);
            while (commonPrefixLength < commonLength && text[commonPrefixLength] == this.currentText[commonPrefixLength])
            {
                commonPrefixLength++;
            }

            // Backtrack to the first differing character
            var outputBuilder = new StringBuilder();
            outputBuilder.Append('\b', this.currentText.Length - commonPrefixLength);

            // Output new suffix
            outputBuilder.Append(text.Substring(commonPrefixLength));

            // If the new text is shorter than the old one: delete overlapping characters
            var overlapCount = this.currentText.Length - text.Length;
            if (overlapCount > 0)
            {
                outputBuilder.Append(' ', overlapCount);
                outputBuilder.Append('\b', overlapCount);
            }

            Console.Write(outputBuilder);
            this.currentText = text;
        }

        private void ResetTimer()
        {
            this.timer.Change(this.animationInterval, TimeSpan.FromMilliseconds(-1));
        }
    }
}