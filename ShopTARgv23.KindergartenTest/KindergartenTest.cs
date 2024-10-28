using ShopTARgv23.ApplicationServices.Services;
using ShopTARgv23.Core.Domain;
using ShopTARgv23.Core.Dto;
using ShopTARgv23.Core.ServiceInterface;


namespace ShopTARgv23.KindergartenTest
{
    public class KindergartenTest : TestBase
    {

        [Fact]

        public async Task Should_Create_Kindergarten()
        {
            var dto = new KindergartenDto
            {
                GroupName = "test123",
                ChildrenCount = 123,
                KindergartenName = "TEST123",
                Teacher = "Mister Test"
            };

            var createdKindergarten = await Svc<IKindergartenServices>().Create(dto);

            Assert.NotNull(createdKindergarten);
            Assert.Equal(dto.GroupName, createdKindergarten.GroupName);
            Assert.Equal(dto.ChildrenCount, createdKindergarten.ChildrenCount);
            Assert.Equal(dto.KindergartenName, createdKindergarten.KindergartenName);
            Assert.Equal(dto.Teacher, createdKindergarten.Teacher);
        }
        
        [Fact]
        public async Task Should_Update_Kindergarten()
        {
            var dto = new KindergartenDto
            {
                GroupName = "Test 1",
                ChildrenCount = 127,
                KindergartenName = "Apple tree",
                Teacher = "John",
            };
            var created = await Svc<IKindergartenServices>().Create(dto);

            var updateDto = new KindergartenDto
            {

                GroupName = "Test 2",
                ChildrenCount = 125,
                KindergartenName = "Pear tree",
                Teacher = "Jane"
            };

            var updatedKindergarten = await Svc<IKindergartenServices>().Update(updateDto);

            Assert.NotNull(updatedKindergarten);
            Assert.Equal(updateDto.GroupName, updatedKindergarten.GroupName);
            Assert.Equal(updateDto.ChildrenCount, updatedKindergarten.ChildrenCount);
            Assert.Equal(updateDto.KindergartenName, updatedKindergarten.KindergartenName);
            Assert.Equal(updateDto.Teacher, updatedKindergarten.Teacher);
        }

        [Fact]
        public async Task Should_Delete_Kindergarten()
        {
            var dto = new KindergartenDto
            {

                GroupName = "Robots",
                ChildrenCount = 10,
                KindergartenName = "Flower",
                Teacher = "William"
            };
            var created = await Svc<IKindergartenServices>().Create(dto);
            var deletedKindergarten = await Svc<IKindergartenServices>().Delete((Guid)created.Id);

            Assert.Equal(deletedKindergarten, created);

            
        }

        [Fact]

        public async Task ShouldNot_AddEmptyKindergarten_WhenReturnResult()
        {
            //Arrange
            KindergartenDto dto = new();

            dto.Id = null;
            dto.GroupName = "asd";
            dto.ChildrenCount = 123;
            dto.KindergartenName = "Alpha";
            dto.Teacher = "asd";

            
            var result = await Svc<IKindergartenServices>().Create(dto);

            //Assert
            Assert.NotNull(result);
        }


    }
}