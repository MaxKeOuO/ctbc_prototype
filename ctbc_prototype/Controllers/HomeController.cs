using ctbc_prototype.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ctbc_prototype.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(BaseModel baseModel)
        {
            baseModel.BarItems = GetBarItem();


            return View(baseModel);
        }

        public IActionResult SingleRiskManage(BaseModel baseModel)
        {
            baseModel.BarItems = GetBarItem();



            return View(baseModel);
        }


        public IActionResult GetRiskList()
        {
            var result = GetDefaultRisk();

            DataTablesReturn dataTablesReturnVo = new DataTablesReturn();

            dataTablesReturnVo.Data = result;


            return Json(dataTablesReturnVo);
        }

        public IActionResult RiskEdit(SimpleRisk input)
        {
            RiskDetail result = new RiskDetail();

            result.BarItems = GetBarItem();

            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private ListBarItem GetBarItem()
        {
            return new ListBarItem()
            {
                SideBarItems = new List<BarItem>()
                {
                    new BarItem() { ItemName = "風險事件提報", ItemHref = "#", Children = new List<BarItem>(){
                        new BarItem() { ItemName = "單一事件提報",ItemHref = "/Home/SingleRiskManage" },
                        new BarItem() { ItemName = "彙總事件上傳",ItemHref = "#" },
                    } },
                    new BarItem() { ItemName = "風險事件確認", ItemHref = "#", Children = new List<BarItem>(){
                        new BarItem() { ItemName = "待確認事件列表", ItemHref = "#" },
                    } },
                    new BarItem() { ItemName = "風險事件追蹤", ItemHref = "#" , Children = new List<BarItem>(){
                        new BarItem() { ItemName = "待追蹤事件列表", ItemHref = "#" },
                        new BarItem() { ItemName = "待結案事件列表", ItemHref = "#" },
                    } },
                    new BarItem() { ItemName = "風險事件審核", ItemHref = "#" , Children = new List<BarItem>(){
                        new BarItem() { ItemName = "待審核事件列表", ItemHref = "#" },
                    } },
                    new BarItem() { ItemName = "風險事件查詢", ItemHref = "#", Children = new List<BarItem>(){
                        new BarItem() { ItemName = "單一事件清單查詢", ItemHref = "#" },
                        new BarItem() { ItemName = "彙總事件清單查詢", ItemHref = "#" },
                    } },
                    new BarItem() { ItemName = "報表", ItemHref = "#", Children = new List<BarItem>(){
                        new BarItem() { ItemName = "未結案追蹤", ItemHref = "#" },
                        new BarItem() { ItemName = "改善方案delay追蹤", ItemHref = "#" },
                    } },
                    new BarItem() { ItemName = "系統管理", ItemHref = "#", Children = new List<BarItem>(){
                        new BarItem() { ItemName = "系統公告維護", ItemHref = "#" },
                        new BarItem() { ItemName = "下拉選項管理", ItemHref = "#" },
                        new BarItem() { ItemName = "授權維護(人員角色/角色功能)", ItemHref = "#" },
                        new BarItem() { ItemName = "彙總項目維護", ItemHref = "#" },
                    }  },
                },
            };
        }

        private List<SimpleRisk> GetDefaultRisk()
        {
            return new List<SimpleRisk>()
            {
                new SimpleRisk() { RId = Guid.NewGuid().ToString(), RDate = DateTime.Now.AddDays(3).ToString("yyyy/MM/dd"), UserName = "王小明", UserDept = "作業風險管理科", Memo = "", RStatus = "提報人已確認" },
                new SimpleRisk() { RId = Guid.NewGuid().ToString(), RDate = DateTime.Now.AddDays(3).ToString("yyyy/MM/dd"), UserName = "林小華", UserDept = "作業風險管理科", Memo = "", RStatus = "提報人已確認" },

            };
        }
    }
}
