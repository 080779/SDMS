﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDMS.DTO.DTO;

namespace Chat.IService.Interface
{
    public interface IChangeTypeService : IServiceSupport
    {
        List<ChangeTypeDTO> GetList();
    }
}
