using BCLservice.ServiceData;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCLservice.ServiceData.BCLservice.ServiceData;

namespace BCLservice.ServiceInterface
{
    public class Building_Service : Service
    {
        public object Any(ServiceModel.BuildingSelect_Request request)
        {
            ServiceModel.BuildingResponse result = new ServiceModel.BuildingResponse();
            ResponseStatus status = new ResponseStatus
            {
                ErrorCode = "Success",
                Message = request.ToString()
            };
            result.Building = dtBuilding.returnBuildingObject();
            return result;
        }
        public object Any(ServiceModel.jBuildingSelect_Request request)
        {
            ServiceModel.jBuildingResponse result = new ServiceModel.jBuildingResponse();
            result.Result = "ERROR";
            try
            {
                result.Records = dtBuilding.returnBuildingObject();
                result.Result = "OK";
            }
            catch (Exception ex)
            {
                result.Result = ex.Message;
            }
            return result;
        }

    }
}
