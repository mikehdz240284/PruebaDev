using SilWMS.Framework.IBaseDomain;
using Models.BaseModels;

namespace SilWMS.Framework.BaseDomain
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericDomain<T> : IGenericDomain<T> where T : BaseModel
    {
    }
}
