using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace DAISY_6.Models.ViewModels
{
    public class DaisyCase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string Race { get; set; }
        public string Occupation { get; set; }
        public string MedicalAid { get; set; }
        public string Medication { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string EmailAddress { get; set; }
        public string Suburb { get; set; }
        public string DLLocation { get; set; }
        public string DLType { get; set; }
        public string DLSource { get; set; }
        public string DLStudentNumber { get; set; }
        public string Counsellor { get; set; }

        public string CallDate { get; set; }
        public string DLCallTimeOfDay { get; set; }
        public string CalledOnBehalfOf { get; set; }

        public string HelpLine { get; set; }

        public Boolean ReasonAcademicStress { get; set; }
        public Boolean ReasonADHD { get; set; }
        public Boolean ReasonAlzheimersDementia { get; set; }
        public Boolean ReasonAnxiety { get; set; }
        public Boolean ReasonBipolar { get; set; }
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
        public Boolean ReasonPTSDTrauma { get; set; }
        public Boolean ReasonReationshipDomesticAbuse { get; set; }
        public Boolean ReasonSchizophrenia { get; set; }
        public Boolean ReasonSelfMutilation { get; set; }
        public Boolean ReasonSexualAbuseRape { get; set; }
        public Boolean ReasonSleepingDisorder { get; set; }
        public Boolean ReasonSocialPhobia { get; set; }
        public Boolean ReasonStress { get; set; }
        public Boolean ReasonSubstanceAbuse { get; set; }
        public Boolean ReasonSuicide { get; set; }

        public Boolean ReasonFrequentCaller { get; set; }
        public Boolean ReasonBullying { get; set; }
        public Boolean ReasonPregnancy { get; set; }
        public Boolean ReasonSexuality { get; set; }
        public Boolean ReasonOtherReason { get; set; }
        public Boolean ReasonFollowUp { get; set; }
        public Boolean ReasonRelationshipRomanticIssues { get; set; }
        public Boolean ReasonRelationshipFamilyIssues { get; set; }

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
        public Boolean ReferRapeCrisis { get; set; }
        public Boolean ReferShelter { get; set; }
        public Boolean ReferSocialWorker { get; set; }
        public Boolean ReferSupportGroup { get; set; }
        public Boolean ReferTraumaCentre { get; set; }
        public Boolean ReferRehabilitationCentre { get; set; }
        public Boolean ReasonBorderlinePersonalityDisorder { get; set; }

        public Boolean ReferCompanyEAP { get; set; }
        public Boolean ReferUniversitySupportServices { get; set; }
        public Boolean ReferUniversityStudentWellness { get; set; }
        public Boolean ReferSadagHelpLine { get; set; }
        public Boolean ReferSelfHelp { get; set; }
        public Boolean ReferUber { get; set; }

        public int DistressRatingBegining { get; set; }
        public int DistressRatingEnd { get; set; }

        [Required, MinLength(100), MaxLength(8000)]
        public string CallSummary { get; set; }

        [Required, MinLength(100), MaxLength(8000)]
        public string ActionPoints { get; set; }

    }

    public class DaisyDedicatedLineCase
    {


    }

    public class SearchCase
    {




    }






}