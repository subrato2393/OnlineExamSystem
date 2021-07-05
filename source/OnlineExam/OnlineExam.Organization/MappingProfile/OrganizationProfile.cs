using AutoMapper;
using EO = OnlineExam.Organization.Entities;
using BO = OnlineExam.Organization.BusinessObjects;

namespace OnlineExam.Organization.MappingProfile
{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<BO.Course, EO.Course>();
        }
    }
}
