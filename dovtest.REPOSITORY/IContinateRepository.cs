
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using dovtest.MODAL;


namespace dovtest.REPOSITORY
{
    public interface IContinateRepository
    {
        //COMMENT: because lack of time it is object instead of model type
          Task<object>  GetContinate();
          //COMMENT: because lack of time it is object instead of model type
          Task<object>  GetContinateGraphQl();
    }
    
}