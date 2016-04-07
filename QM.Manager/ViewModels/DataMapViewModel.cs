﻿using QM.Manager.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QM.Manager.ViewModels {

    [Regist(InstanceMode.None)]
    public class DataMapViewModel : BaseScreen {
        public override string Title {
            get {
                return "参数列表";
            }
        }

        public Dictionary<string, object> Datas { get; set; }

        public override Task Update() {
            return Task.FromResult<object>(null);
        }

        public void Update(Dictionary<string, object> datas) {
            this.Datas = datas;
            this.NotifyOfPropertyChange(() => this.Datas);
        }
    }
}
