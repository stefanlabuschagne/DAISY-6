using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace DAISY_6.Models.ViewModels
{

    public class DaisyCase
    {

        [Required, Display(Name = "Counsellor")]
        public string Counsellor { get; set; }
        [Required, Display(Name = "Time of Day")]
        public string DLCallTimeOfDay { get; set; }
        [Required, Display(Name = "Helpline")]
        public string HelpLine { get; set; }
        [Required, Display(Name = "Called For")]
        public string CalledFor { get; set; }
        [Required, Display(Name = "Called Date")]
        public string CallDate { get; set; }




        [Required, Display(Name = "First Name")]
        public string Name { get; set; }
        [Required, Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required, Display(Name = "Age Group")]
        public string Age { get; set; }
        [Required, Display(Name = "Gender")]
        public string Sex { get; set; }
        [Required, Display(Name = "Race")]
        public string Race { get; set; }
        [Required, Display(Name = "Occupation")]
        public string Occupation { get; set; }
        [Required, Display(Name = "Medical Aid")]
        public string MedicalAid { get; set; }
        [Required, Display(Name = "Medication")]
        public string Medication { get; set; }
        [Required, Display(Name = "Street / Box")]
        public string Address { get; set; }
        [Required, Display(Name = "Suburb")]
        public string Suburb { get; set; }
        [Required, Display(Name = "City")]
        public string City { get; set; }
        [Required, Display(Name = "Province")]
        public string Province { get; set; }
        [Required, Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Required, Display(Name = "Telephone 1")]
        public string Telephone1 { get; set; }
        [Required, Display(Name = "Telephone 2")]
        public string Telephone2 { get; set; }
        [Required, Display(Name = "Email Address"),EmailAddress]
        public string EmailAddress { get; set; }

        [Required, Display(Name = "Academic Stress")]
        public Boolean ReasonAcademicStress { get; set; }
        [Required, Display(Name = "ADHD")]
        public Boolean ReasonADHD { get; set; }
        [Required, Display(Name = "Alzheimers Dementia")]
        public Boolean ReasonAlzheimersDementia { get; set; }

        [Required, Display(Name = "Anxiety")]
        public Boolean ReasonAnxiety { get; set; }

        [Required, Display(Name = "Bipolar")]
        public Boolean ReasonBipolar { get; set; }

        [Required, Display(Name = "Borderline Personality Disorder")]
        public Boolean ReasonBorderlinePersonalityDisorder { get; set; }

        [Required, Display(Name = "Bullying")]
        public Boolean ReasonBullying { get; set; }

        [Required, Display(Name = "Debt Poverty Unemployment")]
        public Boolean ReasonDebtPovertyUnemployment { get; set; }

        [Required, Display(Name = "Depression")]
        public Boolean ReasonDepression { get; set; }

        [Required, Display(Name = "Eating Disoirder")]
        public Boolean ReasonEatingDisoirder { get; set; }

        [Required, Display(Name = "Bipolar")]
        public Boolean ReasonHIVAIDS { get; set; }

        [Required, Display(Name = "Information")]
        public Boolean ReasonInformation { get; set; }

        [Required, Display(Name = "Loss Grief Loneliness")]
        public Boolean ReasonLossGriefLoneliness { get; set; }

        [Required, Display(Name = "None")]
        public Boolean ReasonNone { get; set; }

        [Required, Display(Name = "OCD")]
        public Boolean ReasonOCD { get; set; }

        [Required, Display(Name = "Other Illness")]
        public Boolean ReasonOtherIllness { get; set; }

        [Required, Display(Name = "Physical Emotional Abuse")]
        public Boolean ReasonPhysicalEmotionalAbuse { get; set; }

        [Required, Display(Name = "Post Natal Depression")]
        public Boolean ReasonPostNatalDepression { get; set; }

        [Required, Display(Name = "Pregnancy")]
        public Boolean ReasonPregnancy { get; set; }

        [Required, Display(Name = "PTSD Trauma")]
        public Boolean ReasonPTSDTrauma { get; set; }

        [Required, Display(Name = "Reationship: Domestic Abuse")]
        public Boolean ReasonReationshipDomesticAbuse { get; set; }

        [Required, Display(Name = "Relationship: Family Issues")]
        public Boolean ReasonRelationshipFamilyIssues { get; set; }

        [Required, Display(Name = "Relationship: Romantic Issues")]
        public Boolean ReasonRelationshipRomanticIssues { get; set; }

        [Required, Display(Name = "Schizophrenia")]
        public Boolean ReasonSchizophrenia { get; set; }

        [Required, Display(Name = "Self Mutilation")]
        public Boolean ReasonSelfMutilation { get; set; }

        [Required, Display(Name = "Sexual Abuse Rape")]
        public Boolean ReasonSexualAbuseRape { get; set; }

        [Required, Display(Name = "Sleeping Disorder")]
        public Boolean ReasonSleepingDisorder { get; set; }

        [Required, Display(Name = "SocialPhobia")]
        public Boolean ReasonSocialPhobia { get; set; }

        [Required, Display(Name = "Stress")]
        public Boolean ReasonStress { get; set; }

        [Required, Display(Name = "Substance Abuse")]
        public Boolean ReasonSubstanceAbuse { get; set; }

        [Required, Display(Name = "Suicide")]
        public Boolean ReasonSuicide { get; set; }

        [Required, Display(Name = "Frequent Caller")]
        public Boolean ReasonFrequentCaller { get; set; }

        [Required, Display(Name = "SADAG Face To Face")]
        public Boolean ReferDASGFaceToFace { get; set; }

        [Required, Display(Name = "Company EAP")]
        public Boolean ReferCompanyEAP { get; set; }

        [Required, Display(Name = "GP")]
        public Boolean ReferGP { get; set; }

        [Required, Display(Name = "Goverenment Hospital")]
        public Boolean ReferGovHospital { get; set; }

        [Required, Display(Name = "Literature Website")]
        public Boolean ReferLiteratureWebsite { get; set; }

        [Required, Display(Name = "None")]
        public Boolean ReferNone { get; set; }        
        
        [Required, Display(Name = "Other")]
        public Boolean ReferOther { get; set; }        
        
        [Required, Display(Name = "Other NGO Helpline")]
        public Boolean ReferOtherNGOHelpline { get; set; }        
        
        [Required, Display(Name = "Police Station")]
        public Boolean ReferPoliceStation { get; set; }        
        
        [Required, Display(Name = "Private Hoispital")]
        public Boolean ReferPrivateHospital { get; set; }        
        
        [Required, Display(Name = "Psychiatrist")]
        public Boolean ReferPsychiatrist { get; set; }        
        
        [Required, Display(Name = "Psychologist")]
        public Boolean ReferPsychologist { get; set; }        
        
        [Required, Display(Name = "Rape Crisis")]
        public Boolean ReferRapeCrisis { get; set; }        
        
        [Required, Display(Name = "Rehabilitation Centre")]
        public Boolean ReferRehabilitationCentre { get; set; }        
        
        [Required, Display(Name = "Shelter")]
        public Boolean ReferShelter { get; set; }        
        
        [Required, Display(Name = "Social Worker")]
        public Boolean ReferSocialWorker { get; set; }        
        
        [Required, Display(Name = "Support Group")]
        public Boolean ReferSupportGroup { get; set; }        
        
        [Required, Display(Name = "Trauma Centre")]
        public Boolean ReferTraumaCentre { get; set; }        
        
        [Required, Display(Name = "University Support Services")]
        public Boolean ReferUniversitySupportServices { get; set; }        
        
       
        [Required, Range(1,5), Display(Name = "Distress Rating Start of Call")]
        public int DistressRatingBegining { get; set; }
        [Required, Range(1,5), Display(Name = "Distress Rating End of Call"),]
        public int DistressRatingEnd { get; set; }

        [Required, MinLength(100), MaxLength(8000), Display(Name = "Call Summary:")]
        public string CallSummary { get; set; }

        [Required, MinLength(100), MaxLength(8000),Display(Name="Action Points:")]
        public string ActionPoints { get; set; }

    }



    public class DaisyDedicatedLineCase
    {

        [Required, Display(Name = "Counsellor")]
        public string Counsellor { get; set; }
        [Required, Display(Name = "Time of Day")]
        public string DLCallTimeOfDay { get; set; }
        [Required, Display(Name = "Helpline")]
        public string HelpLine { get; set; }

        [Required, Display(Name = "Called Date")]
        public string CallDate { get; set; }

        [Required, Display(Name = "First Name")]
        public string Name { get; set; }
        [Required, Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required, Display(Name = "Age Group")]
        public string Age { get; set; }
        [Required, Display(Name = "Gender")]
        public string Sex { get; set; }
        [Required, Display(Name = "Race")]
        public string Race { get; set; }
        [Required, Display(Name = "Occupation")]
        public string Occupation { get; set; }
        [Required, Display(Name = "Medical Aid")]
        public string MedicalAid { get; set; }
        [Required, Display(Name = "Medication")]
        public string Medication { get; set; }
        [Required, Display(Name = "Street / Box")]
        public string Address { get; set; }
        [Required, Display(Name = "Suburb")]
        public string Suburb { get; set; }
        [Required, Display(Name = "City")]
        public string City { get; set; }
        [Required, Display(Name = "Province")]
        public string Province { get; set; }
        [Required, Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Required, Display(Name = "Telephone 1")]
        public string Telephone1 { get; set; }
        [Required, Display(Name = "Telephone 2")]
        public string Telephone2 { get; set; }
        [Required, Display(Name = "Email Address")]
        public string EmailAddress { get; set; }


        public string DLLocation { get; set; }
        public string DLType { get; set; }
        public string DLSource { get; set; }
        public string DLStudentNumber { get; set; }


        public Boolean ReasonAcademicStress { get; set; }
        public Boolean ReasonADHD { get; set; }
        public Boolean ReasonAlzheimersDementia { get; set; }
        public Boolean ReasonAnxiety { get; set; }
        public Boolean ReasonBipolar { get; set; }

        public Boolean ReasonBorderlinePersonalityDisorder { get; set; }
        public Boolean ReasonBullying { get; set; }


        public Boolean ReasonDebtPovertyUnemployment { get; set; }
        public Boolean ReasonDepression { get; set; }
        public Boolean ReasonEatingDisoirder { get; set; }
        public Boolean ReasonHIVAIDS { get; set; }
        public Boolean ReasonInformation { get; set; }
        public Boolean ReasonLossGriefLoneliness { get; set; }
        public Boolean ReasonNone { get; set; }
        public Boolean ReasonOCD { get; set; }
        public Boolean ReasonOtherIllness { get; set; }
        public Boolean ReasonPhysicalEmotionalAbuse { get; set; }


        public Boolean ReasonPostNatalDepression { get; set; }
        public Boolean ReasonPregnancy { get; set; }
        public Boolean ReasonPTSDTrauma { get; set; }
        public Boolean ReasonReationshipDomesticAbuse { get; set; }
        public Boolean ReasonSchizophrenia { get; set; }
        public Boolean ReasonSelfMutilation { get; set; }
        public Boolean ReasonSexualAbuseRape { get; set; }
        public Boolean ReasonSexuality { get; set; }
        public Boolean ReasonSleepingDisorder { get; set; }
        public Boolean ReasonSocialPhobia { get; set; }
        public Boolean ReasonStress { get; set; }
        public Boolean ReasonSubstanceAbuse { get; set; }
        public Boolean ReasonSuicide { get; set; }
        public Boolean ReasonFrequentCaller { get; set; }
        public Boolean ReasonOtherReason { get; set; }
        public Boolean ReasonFollowUp { get; set; }


        public Boolean ReferDASGFaceToFace { get; set; }
        public Boolean ReferGP { get; set; }
        public Boolean ReferGovHospital { get; set; }
        public Boolean ReferLiteratureWebsite { get; set; }
        public Boolean ReferNone { get; set; }
        public Boolean ReferOther { get; set; }
        public Boolean ReferOtherNGOHelpline { get; set; }
        public Boolean ReferPoliceStation { get; set; }
        public Boolean ReferPrivateHospital { get; set; }
        public Boolean ReferPsychiatrist { get; set; }
        public Boolean ReferPsychologist { get; set; }
        public Boolean ReferUniversityStudentWellness { get; set; }


        public Boolean ReferRapeCrisis { get; set; }
        public Boolean ReferRehabilitationCentre { get; set; }
        public Boolean ReferShelter { get; set; }
        public Boolean ReferSocialWorker { get; set; }
        public Boolean ReferSupportGroup { get; set; }
        public Boolean ReferTraumaCentre { get; set; }

        public Boolean ReferSadagHelpLine { get; set; }
        public Boolean ReferSelfHelp { get; set; }
        public Boolean ReferUber { get; set; }

        public int DistressRatingBegining { get; set; }
        public int DistressRatingEnd { get; set; }

        [Required, MinLength(100), MaxLength(8000), Display(Name = "Call Summary")]
        public string CallSummary { get; set; }

        [Required, MinLength(100), MaxLength(8000), Display(Name = "Action Points")]
        public string ActionPoints { get; set; }

    }

    public class CallReport
    {

        // Call Report
        [Display(Name="First Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Reason for Call")]
        public string CallReason { get; set; }

        [Display(Name = "Age Group")]
        public string Age { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Province")]
        public string Province { get; set; }

        [Display(Name = "Gender")]
        public string Sex { get; set; }

        [Display(Name = "Race")]
        public string Race { get; set; }

        [Display(Name = "Counsellor")]
        public string Counsellor { get; set; }

        [Display(Name = "Telephone")]
        public string Telephone { get; set; }

        [Display(Name = "From: (yyyy-mm-dd)")]
        public string FromDate { get; set; }

        [Display(Name = "To: (yyyy-mm-dd)")]
        public string ToDate { get; set; }

        [Display(Name = "Search Phrase:")]
        public string SearchPhrase { get; set; }

        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        [Display(Name = "Call Time")]
        public string CallTimeOfDay { get; set; }

        [Display(Name = "Helpline")]
        public string Helpline { get; set; }

        [Display(Name = "List Summary Details Only")]
        public Boolean SummanyDetailsOnly { get; set; }

    }


    public class EditCaller    
    {

        // Edit  Caller
        [Display(Name = "First Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Province")]
        public string Province { get; set; }

        [Display(Name = "Telephone")]
        public string Telephone { get; set; }

        [Display(Name = "Results")]
        public List<DaisyCase> Results { get; set; }

    }


}