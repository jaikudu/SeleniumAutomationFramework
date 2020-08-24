using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework
{
    
    public static class Config
    {
        public static string BaseURL = "http://testing.todvachev.com/";
        public enum Countries
        {
            Australia,
            Canada,
            India,
            Russia,
            USA
        }

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "Validuser";
                public static string Password = "asd1234!";
                public static string RepeatPassword = "asd1234!";
                public static string Email = "example@a.com";
            }
            public static class Invalid
            {
                public static class UserName
                {
                    public static string FourCharacters = "asdf";
                    public static string ThirteenCharacters = "asdfasdfasdfasdfg";
                }
                public static class Password
                {
                    public static string FourCharacters = "asdf";
                    public static string ThirteenCharacters = "asdfasdfasdfasdfg";
                }
                public static class Email
                {

                }
            }
        }

        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Succesful login!";

            public static string UserNameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";

            public static string IncorrectPassword = "Password should not be empty / length be between 5 to 12";
        }

        public static class RegistrationDetails
        {
            public static class Valid
            {
                public static string UserId = "Validuser";
                public static string Password = "asd1234!";
                public static string UserName = "user";
                public static string Address = "abcd123";
                public static string Country = Countries.Australia.ToString();
                public static string Zip = "123";
                public static string Email = "a@b.com";
            }
            public static class Invalid
            {
                public static class UserID
                {
                    public static string FourCharacters = "asdf";
                    public static string ThirteenCharacters = "asdfasdfasdfasdfg";
                }
                public static class Password
                {
                    public static string SixCharacters = "asdfgh";
                    public static string ThirteenCharacters = "asdfasdfasdfasdfg";
                }
                public static class UserName
                {
                    public static string EmptyCharacters = "";
                    public static string NumericCharacters = "1234";
                    public static string AlphaNumericCharacters = "abc1234";
                    public static string SpecialCharacters = "a!";
                }
                public static class Address
                {
                    public static string EmptyCharacters = "";
                    public static string SpecialCharacters = "abcd,123";
                }
                public static class Zip
                {
                    public static string EmptyCharacters = "";
                    public static string AlphaCharacters = "abcd";
                    public static string SpecialCharacters = "1!";
                }
                public static class Email
                {
                    public static string EmptyCharacters = "";
                    public static string AlphaCharacters = "abcd";
                    public static string SpecialCharacters = "1!";
                }
            }
        }
        public static class AlertMessagesForRegister
        {
            public static string SuccessfulLogin = "Succesful login!";

            public static string UserIDLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";

            public static string IncorrectPassword = "Password should not be empty / length be between 7 to 12";
            public static string UserNameError = "Username must have alphabet characters only";
            public static string UserAddressError = "User address must have alphanumeric characters only";
            public static string CountryError = "Select your country from the list";
            public static string ZipError = "ZIP code must have numeric characters only";
            public static string EmailError = "You have entered an invalid email address!";
        }
    }
}
