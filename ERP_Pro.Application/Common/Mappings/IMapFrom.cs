using AutoMapper;

namespace ERP_Pro.Application.Common.Mappings
{
    /// <summary>
    /// واجهة لتعريف التعيين من كيان إلى نموذج العرض
    /// </summary>
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
} 