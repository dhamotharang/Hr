//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee_family_profile
    {
        public int ID { get; set; }
        public string Employee_ProfileId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Is_Reliable { get; set; }
        public int Gender { get; set; }
        public int Family_member_type { get; set; }
        public int Degree_of_kinship { get; set; }
        public int Marital_Status { get; set; }
        public int Status { get; set; }
        public int Id_type { get; set; }
        public int Health_Status2 { get; set; }
        public int Working_status { get; set; }
        public int Emergency_level { get; set; }
        public string NationalityId { get; set; }
        public string Educate_TitleId { get; set; }
        public string Name_of_educational_qualificationId { get; set; }
        public System.DateTime Start_relation_date { get; set; }
        public System.DateTime End_relation_date { get; set; }
        public System.DateTime Birth_date { get; set; }
        public System.DateTime Death_date { get; set; }
        public string Id_number { get; set; }
        public string Father_name { get; set; }
        public string Mother_name { get; set; }
        public bool Subscribed { get; set; }
        public bool Working_in_oil_sector { get; set; }
        public string Position_title { get; set; }
        public string Company_name { get; set; }
        public string Company_address { get; set; }
        public bool Working_in_company { get; set; }
        public string Employee_Profile_WorkId { get; set; }
        public bool Is_emergency_contact_person { get; set; }
        public string Home_phone_number { get; set; }
        public string Mobil_phone_number { get; set; }
        public string Address { get; set; }
        public Nullable<int> Educate_Title_ID { get; set; }
        public Nullable<int> Employee_Profile_ID { get; set; }
        public Nullable<int> Name_of_educational_qualification_ID { get; set; }
        public Nullable<int> Nationality_ID { get; set; }
    
        public virtual Educate_Title Educate_Title { get; set; }
        public virtual Employee_Profile Employee_Profile { get; set; }
        public virtual Name_of_educational_qualification Name_of_educational_qualification { get; set; }
        public virtual Nationality Nationality { get; set; }
    }
}
