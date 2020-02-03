using System;
using System.Collections.Generic;
using System.Text;
using SampleCoreApp.Domain.interfaces.repository;
using SampleCoreApp.Domain.interfaces.services;

namespace SampleCoreApp.Services {
     public  class EmployeeService: IEmployeeService {
        public IEmployeeRepository employeeRepository;
        public EmployeeService(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }
        public int Add()
        {
            return employeeRepository.Add() + 3;
        }
    }
}
