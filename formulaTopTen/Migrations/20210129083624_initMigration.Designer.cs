﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using formulaTopTen.Models;

namespace formulaTopTen.Migrations
{
    [DbContext(typeof(ApplikationDbContext))]
    [Migration("20210129083624_initMigration")]
    partial class initMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("formulaTopTen.Models.Coment", b =>
                {
                    b.Property<int>("comentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("driverId")
                        .HasColumnType("int");

                    b.HasKey("comentId");

                    b.HasIndex("driverId");

                    b.ToTable("coment");

                    b.HasData(
                        new
                        {
                            comentId = 1,
                            coment = "Alain Marie Pascal Prost OBE, född 24 februari 1955 i 2, är en fransk före detta racerförare och en fyr-tiden Formula One Drivers' Champion. Från 1987 till 2001 höll han rekordet för de flesta Grand Prix segrar tills Michael Schumacher överträffade Prost totala 51 segrar vid 2001 Belgiens Grand Prix. Prost fick 1999 utmärkelsen World Sports Award of the Century i kategorin motorsport.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 1
                        },
                        new
                        {
                            comentId = 2,
                            coment = "Alain Prost är mitt barndoms favorit ofta blev jag kallad Alen Prost av vänner när vi cyklade åkte moppe m.m",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 1
                        },
                        new
                        {
                            comentId = 3,
                            coment = "	Andreas Nikolaus Niki Lauda, född 22 februari 1949 i Wien i Österrike, död 20 maj 2019 i Zürich i Schweiz, var en österrikisk racerförare, känd som trefaldig världsmästare inom Formel 1. Efter sin aktiva karriär slog han sig på flygbolagsverksamhet med Lauda Air. Han är far till racerföraren Mathias Lauda.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 2
                        },
                        new
                        {
                            comentId = 4,
                            coment = "Niki Lauda vann formel 1-VM 1975 med Ferrari. Året därpå skadades han svårt, med bland annat brännskador som följd, vid en krasch under Tysklands Grand Prix 1976 på Nürburgring. Trots att han var mycket nära döden, så var han tillbaka i sin Ferrari endast sex veckor efter olyckan. I en av Grand Prix-historiens mest berömda slutkamper förlorade Niki Lauda mästerskapet till James Hunt; Lauda gav upp i årets sista lopp, Japans Grand Prix 1976. Vid loppet var banan våt och siktförhållandena dåliga. Lauda bröt efter endast två varv.[1] Säsongen 1977 återtog dock Lauda världsmästartiteln.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 2
                        },
                        new
                        {
                            comentId = 5,
                            coment = "Michael Schumacher  German: F1 Driver; born 3 January 1969) is a retired German racing driver who competed in Formula One for Jordan, Benetton, Ferrari and Mercedes. Schumacher has a joint-record seven World Drivers' Championship titles and, at the time of his retirement from the sport in 2012, he held the records for the most wins (91), pole positions (68) and podium finishes (155)—which have since been broken by Lewis Hamilton—while he maintains the records for the most fastest laps (77) and the most races won in a single season (13), amongst others.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 3
                        },
                        new
                        {
                            comentId = 6,
                            coment = "An ambassador for UNESCO, Schumacher has been involved in humanitarian projects and has donated tens of millions of dollars to charity. In December 2013, Schumacher suffered a severe brain injury in a skiing accident. He was placed in a medically induced coma until June 2014. He left hospital in Grenoble for further rehabilitation at the University Hospital of Lausanne, before being relocated to his home to receive medical treatment and rehabilitation privately in September 2014.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 3
                        },
                        new
                        {
                            comentId = 7,
                            coment = "Bengt Ronnie Peterson Born; 14 February 1944 – 11 September 1978) was a Swedish racing driver. Known by the nickname 'SuperSwede', he was a two-time runner-up in the Formula One World Drivers' Championship.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 4
                        },
                        new
                        {
                            comentId = 8,
                            coment = "Superswede: A film about Ronnie Peterson (2017), directed by Henrik Jansson-Schweizer, with the participation of Mario Andretti, Emerson Fittipaldi, Nina Kennedy, and Niki Lauda, is available on YouTube, as are several other short tributes.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 4
                        },
                        new
                        {
                            comentId = 9,
                            coment = "The 1978 Swedish Grand Prix was a Formula One motor race held on 17 June 1978 at the Scandinavian Raceway. It was the eighth race of the 1978 World Championship of F1 Drivers and the 1978 International Cup for F1 Constructors.The 70 - lap race was the only race to feature the Brabham BT46B, with which Niki Lauda took a commanding victory.Riccardo Patrese finished second in an Arrows,with Ronnie Peterson third in a Lotus.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 4
                        },
                        new
                        {
                            comentId = 10,
                            coment = "Ayrton Senna da Silva Brazilian Portuguese: 21 March 1960 – 1 May 1994) was a Brazilian racing driver who won the Formula One World Drivers' Championship in 1988, 1990 and 1991.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 5
                        },
                        new
                        {
                            comentId = 11,
                            coment = "Senna was recognised for his qualifying speed over one lap, and from 1989 until 2006 he held the record for most pole positions. He was also acclaimed for his wet weather performances, such as the 1984 Monaco Grand Prix, the 1985 Portuguese Grand Prix, and the 1993 European Grand Prix.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 5
                        },
                        new
                        {
                            comentId = 12,
                            coment = "Sir Lewis Carl Davidson Hamilton MBE HonFREng (born 7 January 1985) is a British racing driver, activist, fashion designer and musician. He most recently competed in Formula One for Mercedes in 2020, having previously driven for McLaren from 2007 to 2012. In Formula One, Hamilton has won a joint-record seven World Drivers' Championship titles (tied with Michael Schumacher), while he holds the outright records for the most wins (95), pole positions (98) and podium finishes (165), amongst others",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 6
                        },
                        new
                        {
                            comentId = 13,
                            coment = "Fernando Alonso Díaz (Spanish pronunciation: born 29 July 1981) is a Spanish racing driver who won the Formula One World Drivers' Championship in 2005 and 2006 with Renault, having also driven for McLaren, Ferrari and Minardi. With Toyota, Alonso won the 24 Hours of Le Mans twice, in 2018 and 2019, and the FIA World Endurance Championship in 2018–19. In 2019, he won the 24 Hours of Daytona with Wayne Taylor Racing.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 7
                        },
                        new
                        {
                            comentId = 14,
                            coment = "Juan Manuel Fangio from Argentine Born; 24 June 1911 – 17 July 1995), nicknamed El Chueco  or El Maestro (The Master), was an Argentine racing car driver. He dominated the first decade of Formula One racing, winning the World Drivers' Championship five times.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 8
                        },
                        new
                        {
                            comentId = 15,
                            coment = "Emerson Fittipaldi born 12 December 1946) is a semi-retired Brazilian automobile racing driver who won both the Formula One World Championship and the Indianapolis 500 twice each and the CART championship once.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 9
                        },
                        new
                        {
                            comentId = 16,
                            coment = "Nelson Piquet Souto Maior born 17 August 1952), known as Nelson Piquet, is a Brazilian former racing driver and businessman. Since his retirement, Piquet, a three-times World Champion, has been ranked among the greatest Formula One drivers in various motorsport polls.",
                            createdAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            driverId = 10
                        });
                });

            modelBuilder.Entity("formulaTopTen.Models.Driver", b =>
                {
                    b.Property<int>("driverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("driverId");

                    b.ToTable("driver");

                    b.HasData(
                        new
                        {
                            driverId = 1,
                            name = "Alain",
                            surname = "Prost"
                        },
                        new
                        {
                            driverId = 2,
                            name = "Niki",
                            surname = "Lauda"
                        },
                        new
                        {
                            driverId = 3,
                            name = "Michael",
                            surname = "Michael_Schumacher"
                        },
                        new
                        {
                            driverId = 4,
                            name = "Ronnie",
                            surname = "Peterson"
                        },
                        new
                        {
                            driverId = 5,
                            name = "Ayrton",
                            surname = "Senna"
                        },
                        new
                        {
                            driverId = 6,
                            name = "Lewis",
                            surname = "Hamilton"
                        },
                        new
                        {
                            driverId = 7,
                            name = "Fernando",
                            surname = "Alonso"
                        },
                        new
                        {
                            driverId = 8,
                            name = "Juan",
                            surname = "Fangio"
                        },
                        new
                        {
                            driverId = 9,
                            name = "Emerson",
                            surname = "Emerson_Fittipaldi"
                        },
                        new
                        {
                            driverId = 10,
                            name = "Nelson",
                            surname = "Piquet"
                        });
                });

            modelBuilder.Entity("formulaTopTen.Models.Coment", b =>
                {
                    b.HasOne("formulaTopTen.Models.Driver", null)
                        .WithMany("coments")
                        .HasForeignKey("driverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("formulaTopTen.Models.Driver", b =>
                {
                    b.Navigation("coments");
                });
#pragma warning restore 612, 618
        }
    }
}
