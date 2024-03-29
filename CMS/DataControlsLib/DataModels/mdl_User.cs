﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataControlsLib.DataModels
{
    /// <summary>
    /// Data model containing class variables that describe a single user. Includes Equals (and operator) 
    /// override to compare values of class variables in two instances of this class.
    /// </summary>
    public class mdl_User
    {
        public int          UserID              { get; set; }
        public int          UserNumber          { get; set; }
        public int?         Status              { get; set; }
        public string       Status_Desc         { get; set; }
        public int?         Title               { get; set; }
        public string       Title_Desc          { get; set; }
        public string       FirstName           { get; set; }
        public string       LastName            { get; set; }
        public string       Email               { get; set; }
        public string       Phone               { get; set; }
        public string       UserName            { get; set; }
        public string       Organisation        { get; set; }
        public DateTime?    StartDate           { get; set; }
        public DateTime?    EndDate             { get; set; }
        public bool         Priviledged         { get; set; }
        public DateTime?    SEEDAgreement       { get; set; }
        public DateTime?    IRCAgreement        { get; set; }
        public DateTime?    LASERAgreement      { get; set; }
        public DateTime?    DataProtection      { get; set; }
        public DateTime?    InformationSecurity { get; set; }
        public DateTime?    ISET                { get; set; }
        public DateTime?    ISAT                { get; set; }
        public DateTime?    SAFE                { get; set; }
        public long?        TokenSerial         { get; set; }
        public DateTime?    TokenIssued         { get; set; }
        public DateTime?    TokenReturned       { get; set; }

        /// <summary>
        /// Equals override so that the values contained in two instances of this class 
        /// can be compared all at once.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is mdl_User))
                return false;

            var other = obj as mdl_User;

            if (UserNumber              != other.UserNumber       
                || Status               != other.Status       
                || Title                != other.Title        
                || FirstName            != other.FirstName    
                || LastName             != other.LastName     
                || Email                != other.Email        
                || Phone                != other.Phone        
                || UserName             != other.UserName     
                || Organisation         != other.Organisation 
                || StartDate            != other.StartDate    
                || EndDate              != other.EndDate      
                || Priviledged          != other.Priviledged  
                || SEEDAgreement        != other.SEEDAgreement
                || IRCAgreement         != other.IRCAgreement
                || LASERAgreement       != other.LASERAgreement
                || DataProtection       != other.DataProtection
                || InformationSecurity  != other.InformationSecurity
                || ISET                 != other.ISET         
                || ISAT                 != other.ISAT         
                || SAFE                 != other.SAFE         
                || TokenSerial          != other.TokenSerial  
                || TokenIssued          != other.TokenIssued  
                || TokenReturned        != other.TokenReturned
                )
                return false;

            return true;
        }

        /// <summary>
        /// Operator override for == that calls Equals override for this class so that the values contained 
        /// in two instances of this class can be compared all at once.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator ==(mdl_User x, mdl_User y)
        {
            return x.Equals(y);
        }

        /// <summary>
        ///Operator override for != that calls Equals override for this class so that the values contained 
        /// in two instances of this class can be compared all at once.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator !=(mdl_User x, mdl_User y)
        {
            return !(x == y);
        }
    }
}
