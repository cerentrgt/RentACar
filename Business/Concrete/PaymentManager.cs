using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete.Fake;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    public class PaymentManager : IPaymentService
    {
        
        public IResult MakePayment(IPaymentModel paymentModel)
        {
            return new SuccessResult();
        }
    }
}
