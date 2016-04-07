﻿using System.Collections.Generic;

namespace QM.Server.WebApi.Entity {
    public class TypeInfo {

        public string FullName { get; set; }

        public string AssemblyQualifiedName { get; set; }

        public string AssemblyFile { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public IEnumerable<JobParameterInfo> Params { get; set; }
    }
}
