using AutoFixture;
using Makers.TechInterview.Backend.Test2;
using NSubstitute;

namespace Makers.TechInterview.Backend.Tests
{
    public sealed class UnitTestForBackendTest2
    {
        private readonly Fixture _autoFixture;
        private readonly IBackendTest2 _backendTest2;
        private readonly IRepositorio _repo;
        public UnitTestForBackendTest2()
        {
            _autoFixture = new();
            _backendTest2 = Substitute.For<BackendTest2>();
            _repo = Substitute.For<Repositorio>();
        }

        [Fact]
        public void Test1()
        {
            //Arrange
            var libros = _autoFixture.CreateMany<Libro>();
            var autores = _autoFixture.CreateMany<AutorLibro>();
            var result = Enumerable.Empty<ClaseResultado>();
            //Act
            _repo.ObtenerLibros().Returns(libros);
            _repo.ObtenerAutores().Returns(autores);

            _backendTest2.StartAbc().Returns(result);
            //Assert

            Assert.Empty(result);
        }
    }
}