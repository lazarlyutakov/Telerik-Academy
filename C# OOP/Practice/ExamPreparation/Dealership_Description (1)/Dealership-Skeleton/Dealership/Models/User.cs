using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common;
using Dealership.Contracts;
using Dealership.Common.Enums;

namespace Dealership.Models
{
   public class User : IUser
    {
        private const string UserNameProp = "Username";
        private const string FirstNameProp = "Firstname";
        private const string LastNameProp = "Lastname";
        private const string PasswordProp = "Password";
        private const string NoVehiclesProp = "--NO VEHICLES--";
        private const string UserProp = "--USER {0}--";

        private readonly string firstName;
        private readonly string lastName;
        private readonly string username;
        private readonly string password;


        public User(string username, string firstName, string lastName, string password, Role role)
        {
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.Role = role;
            this.Vehicles = new List<IVehicle>();

            this.ValidateFields();
        }


        public string Username
        {
            get
            {
                return this.username;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }

        public Role Role { get; private set; }

        public IList<IVehicle> Vehicles { get; private set; }


        public void AddVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);

            if(this.Role == Role.Normal && this.Vehicles.Count >= 5)
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));
            }

            if (this.Role == Role.Admin)
            {
                throw new ArgumentException(string.Format(Constants.AdminCannotAddVehicles));
            }

            this.Vehicles.Add(vehicle);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);
            this.Vehicles.Remove(vehicle);
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            Validator.ValidateNull(commentToAdd,Constants.CommentCannotBeNull);
            Validator.ValidateNull(vehicleToAddComment, Constants.CommentCannotBeNull);

            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            Validator.ValidateNull(commentToRemove, Constants.CommentCannotBeNull);
            Validator.ValidateNull(vehicleToRemoveComment, Constants.VehicleCannotBeNull);

            if(this.Username != commentToRemove.Author)
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }
            vehicleToRemoveComment.Comments.Remove(commentToRemove);

        }

        public override string ToString()
        {
            return string.Format(Constants.UserToString, this.Username, this.FirstName, this.LastName, this.Role);
        }

        public string PrintVehicles()
        {
            StringBuilder text = new StringBuilder();

            int counter = 1;

            text.AppendLine(string.Format(UserNameProp, this.username));

            if(this.Vehicles.Count <= 0)
            {
                text.AppendLine(NoVehiclesProp);
            }
            else
            {
                foreach (var item in this.Vehicles)
                {
                    text.AppendLine(string.Format("{0}, {1}", counter, item.ToString()));
                    counter++;
                }
            }
            return text.ToString().Trim();
        }


        private void ValidateFields()
        {
            Validator.ValidateNull(this.username, string.Format(Constants.PropertyCannotBeNull, UserNameProp));
            Validator.ValidateSymbols(this.username, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, UserNameProp));
            Validator.ValidateIntRange(this.username.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, UserNameProp, Constants.MinNameLength, Constants.MaxNameLength));

            Validator.ValidateNull(this.firstName, string.Format(Constants.PropertyCannotBeNull, FirstNameProp));
            Validator.ValidateIntRange(this.firstName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, FirstNameProp, Constants.MinNameLength, Constants.MaxNameLength));

            Validator.ValidateNull(this.lastName, string.Format(Constants.PropertyCannotBeNull, LastNameProp));
            Validator.ValidateIntRange(this.lastName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, LastNameProp, Constants.MinNameLength, Constants.MaxNameLength));

            Validator.ValidateNull(this.password, string.Format(Constants.PropertyCannotBeNull, PasswordProp));
            Validator.ValidateSymbols(this.password, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, PasswordProp));
            Validator.ValidateIntRange(this.password.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength, string.Format(Constants.StringMustBeBetweenMinAndMax, PasswordProp, Constants.MinPasswordLength, Constants.MaxPasswordLength));
        }

    }
}
