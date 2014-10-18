using System;
using System.Transactions;

namespace TenantSystem
{
    public class TenantSystemController
    {
        //todo break this method into small methods
        public bool GenerateBill(int tenantId, int pricePerUnit, int currentMeterReading)
        {
            using (var scope = new TransactionScope())
            {
                var meterReadingRepository = new TenantMeterReadingRepository();
                int prevMonthMeterReading = meterReadingRepository.GetPreviousMonthMeterReading(tenantId);

                //create object of meter reading class as per current meter reading
                var tenantMeterReading = new TenantMeterReading
                    {
                        TenantId = tenantId,
                        MeterReading = currentMeterReading,
                        CreatedDate = DateTime.Now
                    };

                //calculate amount payable for current month
                int currentMonthUnitConsumed = tenantMeterReading.MeterReading - prevMonthMeterReading;
                double amountPayable = currentMonthUnitConsumed*pricePerUnit;
                // create object of bill payable class
                var billPayable = new BillPayable
                    {
                        TenantId = tenantId,
                        PricePerUnit = pricePerUnit,
                        UnitConsumed = currentMonthUnitConsumed,
                        AmountPayable = amountPayable,
                        CreatedDate = DateTime.Now
                    };

                //add amount payable class object
                var billPayableRepository = new BillPayableRepository();
                var billPaymentRepository = new BillPaymentRepository();


                meterReadingRepository.Add(tenantMeterReading);
                billPayableRepository.Add(billPayable);
                
                
                var lastBillPaid = billPaymentRepository.GetLastBillPaid(tenantId); //todo need both last bill paid amount and date

                var billInvoice = new BillInvoice
                    {
                        TenantId = tenantId,
                        CurrentMonthPayamentAmount = billPayable.AmountPayable,
                        LastBillPaid = (lastBillPaid == null) ? 0.00 : lastBillPaid.AmountPaid,
                        PendingAmount = 0,
                        LastBillPaidDate = DateTime.Now, //todo this will be changed
                        CreatedDate = DateTime.Now
                    };

                var billInvoiceRepository = new BillInvoiceRepository();
                billInvoiceRepository.Add(billInvoice);

                scope.Complete();
            }
            return true;
        }
    }
}
