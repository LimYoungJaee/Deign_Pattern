using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsMachine newsmachine = new NewsMachine();
            AnnualSubscriber annualSubscriber = new AnnualSubscriber(newsmachine);
            EventSubscriber eventSubscriber = new EventSubscriber(newsmachine);

            newsmachine.setNewsInfo("오늘 한파", "전국 영하 18도 입니다.");
            newsmachine.setNewsInfo("벛꽃 축제합니다.", "다같이 벛꽃보러~");
        }
    }
}
