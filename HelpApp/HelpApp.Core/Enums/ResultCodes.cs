﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace HelpApp.Core.Enums
{
    public enum ResultCodes
    {
        /// <summary>
        /// The ok
        /// </summary>
        /// <autogeneratedoc />
        [Description("OK")] [EnumMember(Value = "0")]
        Ok = 0,

        /// <summary>
        /// The invalid number
        /// </summary>
        /// <autogeneratedoc />
        [Description("Invalid number")] [EnumMember(Value = "1")]
        InvalidNumber = 1,

        /// <summary>
        /// The invalid parameters
        /// </summary>
        /// <autogeneratedoc />
        [Description("Invalid parameters")] [EnumMember(Value = "2")]
        InvalidParameters = 2,

        /// <summary>
        /// The not found
        /// </summary>
        /// <autogeneratedoc />
        [Description("Not found")] [EnumMember(Value = "3")]
        NotFound = 3,

        /// <summary>
        /// The invalid signature
        /// </summary>
        /// <autogeneratedoc />
        [Description("Invalid signature of message")] [EnumMember(Value = "5")]
        InvalidSignature = 5,

        /// <summary>
        /// The invalid username or password
        /// </summary>
        /// <autogeneratedoc />
        [Description("Invalid username or password")] [EnumMember(Value = "6")]
        InvalidUsernameOrPassword = 6,

        /// <summary>
        /// The no priv
        /// </summary>
        /// <autogeneratedoc />
        [Description("Insufficient privileges")] [EnumMember(Value = "8")]
        NoPriv = 8,

        /// <summary>
        /// The login failed
        /// </summary>
        /// <autogeneratedoc />
        [Description("Login failed")] [EnumMember(Value = "9")]
        LoginFailed = 9,

        /// <summary>
        /// The invalid verify code
        /// </summary>
        /// <autogeneratedoc />
        [Description("Invalid verify code")] [EnumMember(Value = "10")]
        InvalidVerifyCode = 10,

        /// <summary>
        /// The not payeed
        /// </summary>
        /// <autogeneratedoc />
        [Description("Order not payeed")] [EnumMember(Value = "11")]
        NotPayeed = 11,

        /// <summary>
        /// The reversal
        /// </summary>
        /// <autogeneratedoc />
        [Description("Reversal")] [EnumMember(Value = "13")]
        Reversal = 13,

        /// <summary>
        /// The transaction identifier already exists
        /// </summary>
        /// <autogeneratedoc />
        [Description("Transaction Id Already Exists")] [EnumMember(Value = "14")]
        TransactionIdAlreadyExists = 14,

        /// <summary>
        /// The customer not found
        /// </summary>
        /// <autogeneratedoc />
        [Description("Customer not found")] [EnumMember(Value = "15")]
        CustomerNotFound = 15,

        /// <summary>
        /// The email still in use
        /// </summary>
        /// <autogeneratedoc />
        [Description("Email is still in use on system")] [EnumMember(Value = "20")]
        EmailStillInUse = 20,

        /// <summary>
        /// The phone still in use
        /// </summary>
        /// <autogeneratedoc />
        [Description("Phone is still in use on system")] [EnumMember(Value = "21")]
        PhoneStillInUse = 21,

        /// <summary>
        /// The user temporary blocked
        /// </summary>
        /// <autogeneratedoc />
        [Description("User is temporary blocked")] [EnumMember(Value = "22")]
        UserTempBlocked = 22,

        /// <summary>
        /// The device hash code not correctly decrypted
        /// </summary>
        /// <autogeneratedoc />
        [Description("Device hash code not correctly decrypted")] [EnumMember(Value = "23")]
        DeviceHashCodeNotCorrectlyDecrypted = 23,

        /// <summary>
        /// The operation failed
        /// </summary>
        /// <autogeneratedoc />
        [Description("Operation failed")] [EnumMember(Value = "24")]
        OperationFailed = 24,

        /// <summary>
        /// The invalid account
        /// </summary>
        /// <autogeneratedoc />
        [Description("Invalid account")] [EnumMember(Value = "27")]
        InvalidAccount = 27,

        /// <summary>
        /// The password changed
        /// </summary>
        /// <autogeneratedoc />
        [Description("Password changed from portal")] [EnumMember(Value = "28")]
        PasswordChanged = 28,

        /// <summary>
        /// The no email found
        /// </summary>
        /// <autogeneratedoc />
        [Description("Email not found to continue")] [EnumMember(Value = "31")]
        NoEmailFound = 31,

        /// <summary>
        /// The user already registered
        /// </summary>
        /// <autogeneratedoc />
        [Description("User already registered")] [EnumMember(Value = "32")]
        UserAlreadyRegistered = 32,

        /// <summary>
        /// The unknown error
        /// </summary>
        /// <autogeneratedoc />
        [Description("Unknown Error")] [EnumMember(Value = "128")]
        UnknownError = 128,

        /// <summary>
        /// The system error
        /// </summary>
        /// <autogeneratedoc />
        [Description("System Error")] [EnumMember(Value = "256")]
        SystemError = 256,

        /// <summary>
        /// The login failed for country
        /// </summary>
        /// <autogeneratedoc />
        [Description("Login error for country")] [EnumMember(Value = "33")]
        LoginFailedForCountry = 33,

        /// <summary>
        /// The login session error
        /// </summary>
        /// <autogeneratedoc />
        [Description("Login session error")] [EnumMember(Value = "34")]
        LoginSessionError = 34,

        /// <summary>
        /// The login pass blocked
        /// </summary>
        /// <autogeneratedoc />
        [Description("Login pass blocked")] [EnumMember(Value = "35")]
        LoginPassBlocked = 35,


        /// <summary>
        /// The user failed
        /// </summary>
        /// <autogeneratedoc />
        [Description("User failed")] [EnumMember(Value = "36")]
        UserFailed = 36,


        /// <summary>
        /// The check login days
        /// </summary>
        /// <autogeneratedoc />
        [Description("Check 90 days")] [EnumMember(Value = "37")]
        CheckLoginDays = 37,

        /// <summary>
        /// The permanent blocked
        /// </summary>
        /// <autogeneratedoc />
        [Description("User was banned")] [EnumMember(Value = "40")]
        PermanentBlocked = 40,

        /// <summary>
        /// The already exists
        /// </summary>
        /// <autogeneratedoc />
        [Description("Already exists")] [EnumMember(Value = "41")]
        AlreadyExists = 41,

        /// <summary>
        /// The invalid password
        /// </summary>
        /// <autogeneratedoc />
        [Description("Invalid password")] [EnumMember(Value = "43")]
        InvalidPassword = 43,

        /// <summary>
        /// The contract is not exists
        /// </summary>
        /// <autogeneratedoc />
        [Description("Contract is not exist")] [EnumMember(Value = "44")]
        ContractIsNotExists = 44,

        /// <summary>
        /// The register failed
        /// </summary>
        /// <autogeneratedoc />
        [Description("Register failed")] [EnumMember(Value = "45")]
        RegisterFailed = 45,

        /// <summary>
        /// The user not found
        /// </summary>
        /// <autogeneratedoc />
        [Description("User not found")] [EnumMember(Value = "46")]
        UserNotFound = 46,

        /// <summary>
        /// The user is not active
        /// </summary>
        /// <autogeneratedoc />
        [Description("User is not active")] [EnumMember(Value = "50")]
        UserIsNotActive = 50,

        /// <summary>
        /// The phone number not correct
        /// </summary>
        /// <autogeneratedoc />
        [Description("Phone Number is not Correct")] [EnumMember(Value = "52")]
        PhoneNumberNotCorrect = 52,

        /// <summary>
        /// The constant parameters not found
        /// </summary>
        /// <autogeneratedoc />
        [Description("Const Params Not Found")] [EnumMember(Value = "58")]
        ConstParamsNotFound = 58,

        /// <summary>
        /// The cant get system date
        /// </summary>
        /// <autogeneratedoc />
        [Description("Cant Get DateTime")][EnumMember(Value = "60")]
        CantGetSysDate = 60,

        /// <summary>
        /// The invalid statement response
        /// </summary>
        /// <autogeneratedoc />
        [Description("Invalid statement response!")]
        [EnumMember(Value = "62")]
        InvalidStatementResponse = 62,

        /// <summary>
        /// The company type is not found
        /// </summary>
        /// <autogeneratedoc />
        [Description("Company Type Is Not Found")]
        [EnumMember(Value = "63")]
        CompanyTypeIsNotFound = 63,

        /// <summary>
        /// The recharge transfer is not success
        /// </summary>
        /// <autogeneratedoc />
        [Description("Recharge Transfer Is Not Success")]
        [EnumMember(Value = "65")]
        RechargeTransferIsNotSuccess = 65,

        /// <summary>
        /// The product not found
        /// </summary>
        /// <autogeneratedoc />
        [Description("ProductNotFound")][EnumMember(Value = "69")]
        ProductNotFound = 69,

        /// <summary>
        /// The not suitable version
        /// </summary>
        [Description("Version isn't suitable")]
        [EnumMember(Value = "71")]
        NotSuitableVersion = 71,

        /// <summary>
        /// The created
        /// </summary>
        [Description("Created")]
        [EnumMember(Value = "72")]
        Created = 72,

        /// <summary>
        /// Down time
        /// </summary>
        [Description("Sistemdə xəta baş verdi. \n" +
                     "Zəhmət olmazsa bir az sonra cəhd edin.")]
        [EnumMember(Value = "73")]
        DownTime = 73,

    }
}
