﻿using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    public class CaseWorkerControl : ICRUD<CaseWorker> {
        private readonly ICRUDAccess<CaseWorker> _caseWorkerAccess;

        public CaseWorkerControl(ICRUDAccess<CaseWorker> caseWorkerAccess) {
            _caseWorkerAccess = caseWorkerAccess;
        } 
        public Task<int> Create(CaseWorker entity) {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id) {
            throw new NotImplementedException();
        }

        public Task<List<CaseWorker>> GetAll() {
            throw new NotImplementedException();
        }

        public Task<CaseWorker> GetValue(int id) {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int id, CaseWorker entity) {
            throw new NotImplementedException();
        }
    }
}
