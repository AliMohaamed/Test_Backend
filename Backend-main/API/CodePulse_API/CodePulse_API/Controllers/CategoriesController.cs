//using CodePulse_API.Data;
//using CodePulse_API.Models.Domain;
//using CodePulse_API.Models.DTO;
//using CodePulse_API.Repositories.Implementation;
//using CodePulse_API.Repositories.Interface;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace CodePulse_API.Controllers
//{
//    //https://localhost:xxxx/api/categories
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CategoriesController : ControllerBase
//    {
//        private readonly ICategoryRepository categoryRepository;

//        public CategoriesController(ICategoryRepository categoryRepository)
//        {
//            this.categoryRepository = categoryRepository;
//        }


//        //
//        [HttpPost]
//        public async Task<IActionResult> CreatCategory(CreateCategoryRequestDto request)

//        {
//            //Map DTO to Domain Model
//            var category = new Category
//            {
//                Name = request.Name,
//                UrlHandle = request.UrlHandle,
//            };

//           await categoryRepository.CreateAsync(category);

//            //Domain model to DTO
//            var response = new CategoryDto
//            {
//                Id = category.Id,
//                Name = category.Name,
//                UrlHandle = category.UrlHandle,
//            };
//            return Ok(response);
//        }
//        //GET:https://localhost:7040/api/Categories
//        [HttpGet]
//        [Authorize]
//        public async Task<IActionResult> GetAllCategories()
//        {
//          var categories =  await categoryRepository.GetAllAsync();
//            //Map Domain model to DTO
//            var response = new List<CategoryDto>();
//            foreach (var category in categories)
//            {
//                response.Add(new CategoryDto
//                {
//                    Id = category.Id,
//                    Name = category.Name,
//                    UrlHandle = category.UrlHandle,

//                });
//            }
//            return Ok(response);
//        }
//        [HttpGet]
//        [Route("{id:Guid}")]

//        //GET:https://localhost:7040/api/categories/{id}
//        public async Task<IActionResult> GetCategoryById([FromRoute]Guid Id)
//        {
//          var existingCategory =  await categoryRepository.GetById(Id);
//            if(existingCategory is null) 
//            {
//                return NotFound();
//            }
//            var response = new CategoryDto
//            { 
//                Id = existingCategory.Id,
//                Name = existingCategory.Name,
//                UrlHandle = existingCategory.UrlHandle
//            };
//            return Ok(response);
//        }
//        //PUT:https://localhost:7040/api/Categories/{id}
//        [HttpPut]
//        [Route("{id:Guid}")]
//        public async Task<IActionResult> EditCategory([FromRoute]Guid id,UpdateCategoryRequestDto request)
//        {
//            //Convert DTO to Domain Model
//            var category = new Category
//            {
//                Id = id,
//                Name = request.Name,
//                UrlHandle = request.UrlHandle, 
//            };
//          category=  await categoryRepository.UpdateAsync(category);
//            if(category == null)
//            {
//                return NotFound();
//            }
//            //Convert Domain model to DTO
//            var response =new CategoryDto
//            { 
//                Id = category.Id,
//                Name = category.Name,
//                UrlHandle = category.UrlHandle,
//            };
//            return Ok(response);
//        }

//        //Delete:https://localhost:7040/api/Categories/{id}
//        [HttpDelete]
//        [Route("{id:Guid}")]
//        public async Task<IActionResult> DeleteCAategory([FromRoute]Guid id)
//        {
//           var category= await categoryRepository.DeleteAsync(id);
//            if(category is null)
//            {
//                return NotFound();
//            }
//            //Convert Domain model to DTo
//            var response = new CategoryDto
//            {
//                Id = category.Id,
//            };
//            return Ok(response);
//        }
//    }
//}
