using Nancy;
using Parcel.Objects;

namespace Parcel
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/form"] = _ =>
            {
                return View["form.cshtml"];
            };

            Get["/parcel"] = _ =>
            {
                ParcelVariables newParcel = new ParcelVariables();
                newParcel.SetLength(Request.Query["length"]);
                newParcel.SetWidth(Request.Query["width"]);
                newParcel.SetHeight(Request.Query["height"]);
                newParcel.SetWeight(Request.Query["weight"]);
                newParcel.SetVolume();
                return View["parcel.cshtml", newParcel];
            };


        }
    }
}