using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SDMS.DTO.DTO;

namespace Chat.IService.Interface
{
    public interface IBonusTypeService : IServiceSupport
    {
        List<BonusTypeDTO> GetList();
    }
}