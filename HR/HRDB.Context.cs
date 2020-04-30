﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HR_ERPEntities : DbContext
    {
        public HR_ERPEntities()
            : base("name=HR_ERPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<A_Q> A_Q { get; set; }
        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<Air_ports> Air_ports { get; set; }
        public virtual DbSet<Allergy_Type> Allergy_Type { get; set; }
        public virtual DbSet<Allowance_years> Allowance_years { get; set; }
        public virtual DbSet<Answer_EOS> Answer_EOS { get; set; }
        public virtual DbSet<Append_beneficiary_Family> Append_beneficiary_Family { get; set; }
        public virtual DbSet<Append_Committe_Member> Append_Committe_Member { get; set; }
        public virtual DbSet<Append_Public_Holidays_Dates> Append_Public_Holidays_Dates { get; set; }
        public virtual DbSet<Applicant_Address_Profile> Applicant_Address_Profile { get; set; }
        public virtual DbSet<Applicant_Attachment_Profile> Applicant_Attachment_Profile { get; set; }
        public virtual DbSet<Applicant_Contact_Profile> Applicant_Contact_Profile { get; set; }
        public virtual DbSet<Applicant_Family_Profile> Applicant_Family_Profile { get; set; }
        public virtual DbSet<Applicant_Military_Service_Profile> Applicant_Military_Service_Profile { get; set; }
        public virtual DbSet<Applicant_Previous_Experiences_Profile> Applicant_Previous_Experiences_Profile { get; set; }
        public virtual DbSet<Applicant_Profile> Applicant_Profile { get; set; }
        public virtual DbSet<Applicant_Qualification_Profile> Applicant_Qualification_Profile { get; set; }
        public virtual DbSet<Applicant_Subscription_Syndicate_Profile> Applicant_Subscription_Syndicate_Profile { get; set; }
        public virtual DbSet<Application_Status> Application_Status { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Authority> Authorities { get; set; }
        public virtual DbSet<Authority_Type> Authority_Type { get; set; }
        public virtual DbSet<Basic_Salary_Calculation_Result> Basic_Salary_Calculation_Result { get; set; }
        public virtual DbSet<Budget_class> Budget_class { get; set; }
        public virtual DbSet<Budget_class_items> Budget_class_items { get; set; }
        public virtual DbSet<Budget_details> Budget_details { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<Business_Test_Profile> Business_Test_Profile { get; set; }
        public virtual DbSet<Business_Trip> Business_Trip { get; set; }
        public virtual DbSet<business_trip_request> business_trip_request { get; set; }
        public virtual DbSet<CasesTM> CasesTMs { get; set; }
        public virtual DbSet<check_list_EOS> check_list_EOS { get; set; }
        public virtual DbSet<Check_List_Item_Groups> Check_List_Item_Groups { get; set; }
        public virtual DbSet<Check_List_Items> Check_List_Items { get; set; }
        public virtual DbSet<Check_Lists_Items> Check_Lists_Items { get; set; }
        public virtual DbSet<check_Request> check_Request { get; set; }
        public virtual DbSet<check_request_change_status> check_request_change_status { get; set; }
        public virtual DbSet<check_request_status> check_request_status { get; set; }
        public virtual DbSet<Checktype> Checktypes { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<Commitee_Agenda> Commitee_Agenda { get; set; }
        public virtual DbSet<Committe_Activities> Committe_Activities { get; set; }
        public virtual DbSet<Committe_Resolution_Recuirtment> Committe_Resolution_Recuirtment { get; set; }
        public virtual DbSet<Committe_subjects> Committe_subjects { get; set; }
        public virtual DbSet<Contact_methods> Contact_methods { get; set; }
        public virtual DbSet<Contract_Information> Contract_Information { get; set; }
        public virtual DbSet<Contract_Type> Contract_Type { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Day_Status_Linkedto_Location> Day_Status_Linkedto_Location { get; set; }
        public virtual DbSet<Definition_of_EOS_Interview_Questions> Definition_of_EOS_Interview_Questions { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Document_Group> Document_Group { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Educate_category> Educate_category { get; set; }
        public virtual DbSet<Educate_Title> Educate_Title { get; set; }
        public virtual DbSet<Employee_Address_Profile> Employee_Address_Profile { get; set; }
        public virtual DbSet<Employee_attachment_profile> Employee_attachment_profile { get; set; }
        public virtual DbSet<Employee_beneficiary_profile> Employee_beneficiary_profile { get; set; }
        public virtual DbSet<Employee_contact_profile> Employee_contact_profile { get; set; }
        public virtual DbSet<Employee_contract_profile> Employee_contract_profile { get; set; }
        public virtual DbSet<Employee_experience_profile> Employee_experience_profile { get; set; }
        public virtual DbSet<Employee_family_profile> Employee_family_profile { get; set; }
        public virtual DbSet<Employee_military_service_calling> Employee_military_service_calling { get; set; }
        public virtual DbSet<Employee_military_service_profile> Employee_military_service_profile { get; set; }
        public virtual DbSet<Employee_Profile> Employee_Profile { get; set; }
        public virtual DbSet<Employee_Profile_Groups> Employee_Profile_Groups { get; set; }
        public virtual DbSet<Employee_Qualification_Profile> Employee_Qualification_Profile { get; set; }
        public virtual DbSet<Employee_Recodes_Group> Employee_Recodes_Group { get; set; }
        public virtual DbSet<Employee_records> Employee_records { get; set; }
        public virtual DbSet<Employee_Shift_schedule> Employee_Shift_schedule { get; set; }
        public virtual DbSet<Employee_sponsor_profile> Employee_sponsor_profile { get; set; }
        public virtual DbSet<Employee_subscription_syndicate_profile> Employee_subscription_syndicate_profile { get; set; }
        public virtual DbSet<Employee_vehicle_profile> Employee_vehicle_profile { get; set; }
        public virtual DbSet<EOS_Interview_Questions_Groups> EOS_Interview_Questions_Groups { get; set; }
        public virtual DbSet<EOS_Request> EOS_Request { get; set; }
        public virtual DbSet<Evalu_Element_Tran> Evalu_Element_Tran { get; set; }
        public virtual DbSet<EvaluationElementCompeteny> EvaluationElementCompetenies { get; set; }
        public virtual DbSet<EvaluationElement> EvaluationElements { get; set; }
        public virtual DbSet<EvaluationGrade> EvaluationGrades { get; set; }
        public virtual DbSet<EvaluationObjective> EvaluationObjectives { get; set; }
        public virtual DbSet<EvaluationPlan> EvaluationPlans { get; set; }
        public virtual DbSet<EvaluationQuestionsandanswer> EvaluationQuestionsandanswers { get; set; }
        public virtual DbSet<EvaluationTransaction> EvaluationTransactions { get; set; }
        public virtual DbSet<EvaluationType> EvaluationTypes { get; set; }
        public virtual DbSet<Evalution_and_competencies> Evalution_and_competencies { get; set; }
        public virtual DbSet<Exchange_Rate> Exchange_Rate { get; set; }
        public virtual DbSet<Exit_Permission_Reason> Exit_Permission_Reason { get; set; }
        public virtual DbSet<Exit_permission_request> Exit_permission_request { get; set; }
        public virtual DbSet<Exit_permission_type> Exit_permission_type { get; set; }
        public virtual DbSet<exper_jobdetails> exper_jobdetails { get; set; }
        public virtual DbSet<Experience_group> Experience_group { get; set; }
        public virtual DbSet<External_compaines> External_compaines { get; set; }
        public virtual DbSet<FileDetailsModel> FileDetailsModels { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<GradeEducate> GradeEducates { get; set; }
        public virtual DbSet<Hiring_Check_List> Hiring_Check_List { get; set; }
        public virtual DbSet<Hiring_Information> Hiring_Information { get; set; }
        public virtual DbSet<In_Organization> In_Organization { get; set; }
        public virtual DbSet<items_man_power> items_man_power { get; set; }
        public virtual DbSet<Job_Details> Job_Details { get; set; }
        public virtual DbSet<Job_level_class> Job_level_class { get; set; }
        public virtual DbSet<job_level_education> job_level_education { get; set; }
        public virtual DbSet<Job_level_grade> Job_level_grade { get; set; }
        public virtual DbSet<job_level_setup> job_level_setup { get; set; }
        public virtual DbSet<job_title_cards> job_title_cards { get; set; }
        public virtual DbSet<Job_title_class> Job_title_class { get; set; }
        public virtual DbSet<Job_title_sub_class> Job_title_sub_class { get; set; }
        public virtual DbSet<justification> justifications { get; set; }
        public virtual DbSet<Linked_to_Testing> Linked_to_Testing { get; set; }
        public virtual DbSet<Main_Educate_body> Main_Educate_body { get; set; }
        public virtual DbSet<man_power> man_power { get; set; }
        public virtual DbSet<Medical_Contributions_Allocations_Entry> Medical_Contributions_Allocations_Entry { get; set; }
        public virtual DbSet<Medical_Contributions_Allocations_Services> Medical_Contributions_Allocations_Services { get; set; }
        public virtual DbSet<Medical_Doctors> Medical_Doctors { get; set; }
        public virtual DbSet<Medical_Doctors_Level> Medical_Doctors_Level { get; set; }
        public virtual DbSet<Medical_Medicine_Classfication> Medical_Medicine_Classfication { get; set; }
        public virtual DbSet<Medical_Service> Medical_Service { get; set; }
        public virtual DbSet<Medical_Service_Classification> Medical_Service_Classification { get; set; }
        public virtual DbSet<Medical_Service_Group> Medical_Service_Group { get; set; }
        public virtual DbSet<Medical_Test_Profile> Medical_Test_Profile { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<mental> mentals { get; set; }
        public virtual DbSet<Military_Service_Rank> Military_Service_Rank { get; set; }
        public virtual DbSet<Military_Service_Status> Military_Service_Status { get; set; }
        public virtual DbSet<month> months { get; set; }
        public virtual DbSet<Name_of_educational_qualification> Name_of_educational_qualification { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<obje_eval_tran> obje_eval_tran { get; set; }
        public virtual DbSet<Organization_Chart> Organization_Chart { get; set; }
        public virtual DbSet<Organization_Unit_Level> Organization_Unit_Level { get; set; }
        public virtual DbSet<Organization_Unit_Schema> Organization_Unit_Schema { get; set; }
        public virtual DbSet<Organization_Unit_Type> Organization_Unit_Type { get; set; }
        public virtual DbSet<Out_Organization> Out_Organization { get; set; }
        public virtual DbSet<per_emp> per_emp { get; set; }
        public virtual DbSet<PerformanceEvaluationGroupEvaluationElement> PerformanceEvaluationGroupEvaluationElements { get; set; }
        public virtual DbSet<PerformanceEvaluationGroup> PerformanceEvaluationGroups { get; set; }
        public virtual DbSet<Personnel_Committee_Profile> Personnel_Committee_Profile { get; set; }
        public virtual DbSet<Personnel_Information> Personnel_Information { get; set; }
        public virtual DbSet<personnel_transaction> personnel_transaction { get; set; }
        public virtual DbSet<PlaneSchedule> PlaneSchedules { get; set; }
        public virtual DbSet<Position_Information> Position_Information { get; set; }
        public virtual DbSet<Position_Information_Rec> Position_Information_Rec { get; set; }
        public virtual DbSet<Position_Transaction_Information> Position_Transaction_Information { get; set; }
        public virtual DbSet<postcode> postcodes { get; set; }
        public virtual DbSet<Public_Holiday_Events> Public_Holiday_Events { get; set; }
        public virtual DbSet<Public_Holidays_Dates> Public_Holidays_Dates { get; set; }
        public virtual DbSet<Qualification_Major> Qualification_Major { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Questions_Performance> Questions_Performance { get; set; }
        public virtual DbSet<qulification_job> qulification_job { get; set; }
        public virtual DbSet<Rejection_Reasons> Rejection_Reasons { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<request_new_contract> request_new_contract { get; set; }
        public virtual DbSet<Required_Licenses> Required_Licenses { get; set; }
        public virtual DbSet<Requirment> Requirments { get; set; }
        public virtual DbSet<Responsibility> Responsibilities { get; set; }
        public virtual DbSet<Risk> Risks { get; set; }
        public virtual DbSet<Risks_Type> Risks_Type { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Schedule_Details> Schedule_Details { get; set; }
        public virtual DbSet<Service_Information> Service_Information { get; set; }
        public virtual DbSet<Shift_day_status_setup> Shift_day_status_setup { get; set; }
        public virtual DbSet<Shift_setup> Shift_setup { get; set; }
        public virtual DbSet<Shiftdaystatu> Shiftdaystatus { get; set; }
        public virtual DbSet<Sings_Symptom> Sings_Symptom { get; set; }
        public virtual DbSet<skill_eval> skill_eval { get; set; }
        public virtual DbSet<Skill_group> Skill_group { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<skills_job> skills_job { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }
        public virtual DbSet<special_allowance_job_level_class> special_allowance_job_level_class { get; set; }
        public virtual DbSet<special_allowance_job_level_grade> special_allowance_job_level_grade { get; set; }
        public virtual DbSet<Special_Allwonce_History> Special_Allwonce_History { get; set; }
        public virtual DbSet<special> specials { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<StructureModel> StructureModels { get; set; }
        public virtual DbSet<Sub_educational_body> Sub_educational_body { get; set; }
        public virtual DbSet<Subscription_Syndicate> Subscription_Syndicate { get; set; }
        public virtual DbSet<Territory> Territories { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<the_states> the_states { get; set; }
        public virtual DbSet<TicketPrice> TicketPrices { get; set; }
        public virtual DbSet<Time_management_action_setup> Time_management_action_setup { get; set; }
        public virtual DbSet<Time_management_conditional_setup> Time_management_conditional_setup { get; set; }
        public virtual DbSet<TransportationMethod> TransportationMethods { get; set; }
        public virtual DbSet<Vacations_Setup> Vacations_Setup { get; set; }
        public virtual DbSet<Weekend_setup> Weekend_setup { get; set; }
        public virtual DbSet<work_location> work_location { get; set; }
        public virtual DbSet<workpermissionrequest> workpermissionrequests { get; set; }
    }
}