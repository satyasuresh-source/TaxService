﻿using MunicipalityService.Models;
using System;
using System.Collections.Generic;

namespace MunicipalityService.DataAccess.Interfaces
{
    public interface ITaxDataAccess
    {
        Municipality GetTaxDetails(string name, DateTime date);

        IEnumerable<Municipality> GetALLTaxDetails();

        bool Save(Municipality municipality);

        bool Update(Municipality municipality);
    }
}
