﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RatnoTech.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RatnoTechEntities1 : DbContext
    {
        public RatnoTechEntities1()
            : base("name=RatnoTechEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Registration> Registrations { get; set; }
    
        public virtual int login_cred(string uname, string pass)
        {
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("login_cred", unameParameter, passParameter);
        }
    
        public virtual int login_credentials(string uname, string pass, ObjectParameter s)
        {
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("login_credentials", unameParameter, passParameter, s);
        }
    
        public virtual int Sp_Login(string username, string password, ObjectParameter isvalid)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Login", usernameParameter, passwordParameter, isvalid);
        }
    
        public virtual int login_credential(string uname, string pass)
        {
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("login_credential", unameParameter, passParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Validate_User(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Validate_User", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Registration> ValidateUser(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Registration>("ValidateUser", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Registration> ValidateUser(string username, string password, MergeOption mergeOption)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Registration>("ValidateUser", mergeOption, usernameParameter, passwordParameter);
        }
    }
}