using BCLservice.ServiceData;
using ServiceStack;
using System;
using System.Collections.Generic;
using BCLservice.ServiceData.BCLservice.ServiceData;
using BCLservice.ServiceData.Objects;

namespace BCLservice.ServiceInterface
{
    public class jTableOptions_Services : Service
    {

        public object Any(ServiceModel.jBuildingOptions_Request request)
        {
            ServiceModel.jBuildingOptionsResponse result = new ServiceModel.jBuildingOptionsResponse();
            result.Result = "ERROR";
            try
            {
                result.Options = dtTableOptions_Services.returnBuildingOptionsObject();
                result.Result = "OK";
                result.Message = "";
            }
            catch (Exception ex)
            {
                result.Result = "ERROR";
                result.Message = ex.Message;
            }
            return result;
        }
    }

}
