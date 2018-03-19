using Chat.IService.Interface;
using Chat.Service.Entities;
using Chat.WebCommon;
using System.Linq;


namespace Chat.Service.Service
{
    public class AccountService: IAccountService
    {
        /// <summary>
        /// 获得总收入
        /// </summary>
        /// <returns></returns>
        public decimal GetIncomeTotal()
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<UserRecordEntity> cs = new CommonService<UserRecordEntity>(dbc);

                var money = cs.GetAll().Where(s => s.ReType == 2).Sum(m => m.ReMoney);
                
                return money;
            }

        }
        /// <summary>
        /// 获得总支出
        /// </summary>
        /// <returns></returns>
        public decimal GetPayTotal()
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<BonusEntity> cs = new CommonService<BonusEntity>(dbc);

                var money = cs.GetAll().Sum(m => m.Sf);

                return money;
            }
            
        }
    }
}
