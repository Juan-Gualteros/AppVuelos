// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("API.Entities.AppFlights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("aerolinea")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ciudadDestino")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ciudadOrigen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("estadoDelVuelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("fecha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("horaLlegada")
                        .HasColumnType("INTEGER");

                    b.Property<int>("horaSalida")
                        .HasColumnType("INTEGER");

                    b.Property<int>("numeroDeVuelo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vuelos");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
