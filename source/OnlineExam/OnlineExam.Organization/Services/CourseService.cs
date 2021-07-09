using AutoMapper;
using OnlineExam.Organization.Entities;
using OnlineExam.Organization.UnitOfWorks;
using System;
using System.Collections.Generic;
using CourseBO = OnlineExam.Organization.BusinessObjects.Course;
using CourseEO = OnlineExam.Organization.Entities.Course;
using CourseTagBO = OnlineExam.Organization.BusinessObjects.CourseTag;
using CourseTagEO = OnlineExam.Organization.Entities.CourseTag;

namespace OnlineExam.Organization.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseUnitOfWork _courseUnitOfWork;
        private readonly IMapper _mapper;
        public CourseService(ICourseUnitOfWork courseUnitOfWork,
            IMapper mapper)
        {
            _courseUnitOfWork = courseUnitOfWork;
            _mapper = mapper;
        }

        public Guid AddCourseInfo(CourseBO courseBO)
        {
            var courseEntity = _mapper.Map<CourseEO>(courseBO);

            _courseUnitOfWork.CourseRepository.Add(courseEntity);
             
            _courseUnitOfWork.Save();

           return GetIdentityColumn(courseEntity);
        }

        public void AddCourseTagInfo(CourseTagBO courseTagBo)
        {
            var courseTagEo = _mapper.Map<CourseTagEO>(courseTagBo);

            _courseUnitOfWork.CourseTagRepository.Add(courseTagEo);

            _courseUnitOfWork.Save();
        }

        public IList<Tag> GetAllTag()
        {
            return _courseUnitOfWork.TagRepository.GetAll();
        }

        public Guid GetIdentityColumn(CourseEO courseEo)
        {
            var courseBo = _mapper.Map<CourseBO>(courseEo);

            return courseBo.Id;
        }
    }
}
