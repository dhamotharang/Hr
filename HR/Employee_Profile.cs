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
    
    public partial class Employee_Profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_Profile()
        {
            this.business_trip_request = new HashSet<business_trip_request>();
            this.check_request_change_status = new HashSet<check_request_change_status>();
            this.check_request_change_status1 = new HashSet<check_request_change_status>();
            this.Contract_Information = new HashSet<Contract_Information>();
            this.Employee_Address_Profile = new HashSet<Employee_Address_Profile>();
            this.Employee_attachment_profile = new HashSet<Employee_attachment_profile>();
            this.Employee_beneficiary_profile = new HashSet<Employee_beneficiary_profile>();
            this.Employee_contact_profile = new HashSet<Employee_contact_profile>();
            this.Employee_contract_profile = new HashSet<Employee_contract_profile>();
            this.Employee_experience_profile = new HashSet<Employee_experience_profile>();
            this.Employee_family_profile = new HashSet<Employee_family_profile>();
            this.Employee_military_service_calling = new HashSet<Employee_military_service_calling>();
            this.Employee_military_service_profile = new HashSet<Employee_military_service_profile>();
            this.Employee_Qualification_Profile = new HashSet<Employee_Qualification_Profile>();
            this.Employee_records = new HashSet<Employee_records>();
            this.Employee_Shift_schedule = new HashSet<Employee_Shift_schedule>();
            this.Employee_sponsor_profile = new HashSet<Employee_sponsor_profile>();
            this.Employee_subscription_syndicate_profile = new HashSet<Employee_subscription_syndicate_profile>();
            this.Employee_vehicle_profile = new HashSet<Employee_vehicle_profile>();
            this.EOS_Request = new HashSet<EOS_Request>();
            this.EvaluationTransactions = new HashSet<EvaluationTransaction>();
            this.Exit_permission_request = new HashSet<Exit_permission_request>();
            this.Organization_Chart = new HashSet<Organization_Chart>();
            this.per_emp = new HashSet<per_emp>();
            this.personnel_transaction = new HashSet<personnel_transaction>();
            this.Position_Information = new HashSet<Position_Information>();
            this.request_new_contract = new HashSet<request_new_contract>();
            this.Slots = new HashSet<Slot>();
            this.workpermissionrequests = new HashSet<workpermissionrequest>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Full_Name { get; set; }
        public string Arabic { get; set; }
        public string Full { get; set; }
        public string Surname { get; set; }
        public string Sur_Name { get; set; }
        public int Gender { get; set; }
        public int Marital_Status { get; set; }
        public string ReligionId { get; set; }
        public string NationalityId { get; set; }
        public bool Citizen { get; set; }
        public int Blood_group { get; set; }
        public int ID_type { get; set; }
        public int Health_Status { get; set; }
        public System.DateTime Birth_date { get; set; }
        public string ID_number { get; set; }
        public string ID_number_in_attendance_machine { get; set; }
        public System.DateTime Issue_date { get; set; }
        public System.DateTime Expire_date { get; set; }
        public string Countryid { get; set; }
        public string Countryaddressid { get; set; }
        public string Areaid { get; set; }
        public string Areaaddressid { get; set; }
        public string the_statesid { get; set; }
        public string the_statesaddressid { get; set; }
        public string Territoriesid { get; set; }
        public string Territoriesaddressid { get; set; }
        public string citiesid { get; set; }
        public string citiesaddressid { get; set; }
        public bool Active { get; set; }
        public string EmpProfileIMG { get; set; }
        public Nullable<int> Ability_ID { get; set; }
        public Nullable<int> Area_ID { get; set; }
        public Nullable<int> cities_ID { get; set; }
        public Nullable<int> Country_ID { get; set; }
        public Nullable<int> Nationality_ID { get; set; }
        public Nullable<int> Personnel_Information_ID { get; set; }
        public Nullable<int> Position_Transaction_Information_ID { get; set; }
        public Nullable<int> Religion_ID { get; set; }
        public Nullable<int> Service_Information_ID { get; set; }
        public Nullable<int> Territories_ID { get; set; }
        public Nullable<int> the_states_ID { get; set; }
    
        public virtual Ability Ability { get; set; }
        public virtual Area Area { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_trip_request> business_trip_request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<check_request_change_status> check_request_change_status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<check_request_change_status> check_request_change_status1 { get; set; }
        public virtual city city { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract_Information> Contract_Information { get; set; }
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Address_Profile> Employee_Address_Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_attachment_profile> Employee_attachment_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_beneficiary_profile> Employee_beneficiary_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_contact_profile> Employee_contact_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_contract_profile> Employee_contract_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_experience_profile> Employee_experience_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_family_profile> Employee_family_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_military_service_calling> Employee_military_service_calling { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_military_service_profile> Employee_military_service_profile { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual Personnel_Information Personnel_Information { get; set; }
        public virtual Position_Transaction_Information Position_Transaction_Information { get; set; }
        public virtual Religion Religion { get; set; }
        public virtual Service_Information Service_Information { get; set; }
        public virtual Territory Territory { get; set; }
        public virtual the_states the_states { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Qualification_Profile> Employee_Qualification_Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_records> Employee_records { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Shift_schedule> Employee_Shift_schedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_sponsor_profile> Employee_sponsor_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_subscription_syndicate_profile> Employee_subscription_syndicate_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_vehicle_profile> Employee_vehicle_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EOS_Request> EOS_Request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvaluationTransaction> EvaluationTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exit_permission_request> Exit_permission_request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Organization_Chart> Organization_Chart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<per_emp> per_emp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personnel_transaction> personnel_transaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Position_Information> Position_Information { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<request_new_contract> request_new_contract { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slot> Slots { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workpermissionrequest> workpermissionrequests { get; set; }
    }
}
