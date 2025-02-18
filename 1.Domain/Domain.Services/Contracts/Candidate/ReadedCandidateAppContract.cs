﻿using Domain.Model.Enum;
using Domain.Services.Contracts.CandidateSkill;
using Domain.Services.Contracts.Consultant;
using Domain.Services.Contracts.Office;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Contracts.Candidate
{
    public class ReadedCandidateAppContract
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DNI { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string LinkedInProfile { get; set; }
        public string AdditionalInformation { get; set; }
        public EnglishLevel EnglishLevel { get; set; }
        public CandidateStatus Status { get; set; }
        public ReadedConsultantContract Recruiter { get; set; }
        public ReadedOfficeContract PreferredOffice { get; set; }
        public DateTime ContactDay { get; set; }

        public ICollection<ReadedCandidateAppSkillContract> CandidateSkills { get; set; }
    }
}
