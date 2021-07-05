using AutoMapper;
using OnlineExam.Organization.UnitOfWorks;
using CourseBO = OnlineExam.Organization.BusinessObjects.Course;
using CourseEO = OnlineExam.Organization.Entities.Course;

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

        public void AddCourseInfo(CourseBO courseBO)
        {
            var courseEntity = _mapper.Map<CourseEO>(courseBO);
            _courseUnitOfWork.CourseRepository.Add(courseEntity);
            _courseUnitOfWork.Save();
        }
    }
}
