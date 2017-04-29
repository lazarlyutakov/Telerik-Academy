﻿using SchoolSystem.Enums;

namespace SchoolSystem.Contracts
{
    public interface ITeacher
    {
        string FirstName { get; }

        string LastName { get; }

        Subject Subject { get; }

        void AddMark(IStudent student, float mark);
    }
}