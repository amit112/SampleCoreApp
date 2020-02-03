using SampleCoreApp.Domain.interfaces;
using SampleCoreApp.Domain.interfaces.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCoreApp.Repository {
     public  class EmployeeRepository: IEmployeeRepository {
        public int Add()
        {
            return 1;
        }
    }
}
