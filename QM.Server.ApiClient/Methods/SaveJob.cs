﻿using QM.Server.WebApi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace QM.Server.ApiClient.Methods {
    public class SaveJob : BaseMethod<JobSaveStates> {
        public override HttpMethod HttpMethod {
            get {
                return HttpMethod.Put;
            }
        }

        public override string Model {
            get {
                return "Jobs";
            }
        }

        [Required]
        public string Name { get; set; }

        public string Group { get; set; }

        public string Desc { get; set; }

        public bool Durability { get; set; }

        public bool ShouldRecover { get; set; }

        public Dictionary<string, object> Parameters { get; set; }

        public bool ReplaceExists { get; set; }

        private string JobType = null;
        private string AssemblyFile = null;

        public SaveJob(string jobType, string assemblyFile) {
            if (string.IsNullOrWhiteSpace(jobType) || string.IsNullOrWhiteSpace(assemblyFile))
                throw new ArgumentException();

            this.JobType = jobType;
            this.AssemblyFile = assemblyFile;
        }

        protected override object GetSendData() {
            return new JobInfo() {
                JobType = new JobType(this.JobType, this.AssemblyFile),
                Desc = this.Desc,
                Durability = this.Durability,
                Group = this.Group,
                Name = this.Name,
                ShouldRecover = this.ShouldRecover,
                DataMap = this.Parameters,
                ReplaceExists = this.ReplaceExists
            };
        }
    }
}
