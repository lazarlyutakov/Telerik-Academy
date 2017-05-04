using SchoolSystem.Enums;

namespace SchoolSystem.Contracts
{
    public interface ITeacher
    {
        Subject Subject { get; set; }

        void AddMark(IStudent student, float mark);
    }
}
