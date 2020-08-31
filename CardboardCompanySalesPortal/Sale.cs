using System;
using System.Collections.Generic;
using System.Text;

namespace CardboardCompanySalesPortal
{
    class Sale
    {
        public string SelectedSalesEmployee { get; set; }
        public string ClientName { get; set; }
        public string ClientIdNumber { get; set; }
        public string TotalSalePrice { get; set; }
        public string RecurringSale { get; set; }
        public string TimeFrameForRecurringSale { get; set; }


        public Sale(string selectedSalesEmployee, string clientName, string clientIdNumber, string totalSalePrice, string recurringSale, string timeFrameForRecurringSale)
        {
            SelectedSalesEmployee = selectedSalesEmployee;
            ClientName = clientName;
            ClientIdNumber = clientIdNumber;
            TotalSalePrice = totalSalePrice;
            RecurringSale = recurringSale;
            TimeFrameForRecurringSale = timeFrameForRecurringSale;
        }


    }
}
