using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop_1._0.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Data
{
    public class DbObjects
    {
        private static Dictionary<string, Category> _category;

        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c=>c.Value));

            if (!content.Book.Any())
            {
                content.AddRange(
                    new Book
                    {
                        Name = "C#",
                        BookAuthor = "Албахари",
                        ShortDescription = "Руководство/справочник языка C#",
                        LongDescription = "Эта книга подойдёт тем кто только начинает изучать язык программирования C#",
                        Img = "/img/Albahary.jpg",
                        Price = 1000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Программирование"]
                    },
                    new Book
                    {
                        Name = "CLR via C# .Net Framework 4.5",
                        BookAuthor = "Джеффри Рихтер",
                        ShortDescription = "Программирование на платформе Microsoft .Net Framework",
                        LongDescription = "Эта книга подойдёт тем кто долго изучает C#, и имеет не малый опыт работы с ним",
                        Img = "/img/Rihter.jpg",
                        Price = 1000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Программирование"]
                    },
                    new Book
                    {
                        Name = "Хоббит: Туда и обратно",
                        BookAuthor = "Толкин",
                        ShortDescription = "История одного путишествия",
                        LongDescription = "Данная история рассказывает о путишествии одного хоббита, который в компании гномов и мага идут к Одинокой Горе",
                        Img = "/img/The Gobbit there and reverse.jpg",
                        Price = 375,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Фантастика"]
                    },
                    new Book
                    {
                        Name = "Записки о Шерлоке Холмсе",
                        BookAuthor = "Конан Дойл",
                        ShortDescription = "Детектив",
                        LongDescription = "Рассказ о одном сыщике, которому разгадки самых сложных тайн, даются с необычайной лёгкостью",
                        Img = "/img/Notes about Sherlock Holmes.jpg",
                        Price = 244,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Детектив"]
                    },
                    new Book
                    {
                        Name = "Сборник сказок",
                        BookAuthor = "Пушкин",
                        ShortDescription = "Сказки для детей",
                        LongDescription = "Сказки которые понравятся и взрослым и детям",
                        Img = "/img/Pushkin Skazki.jpg",
                        Price = 244,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Художественная литература"]
                    },
                    new Book
                    {
                        Name = "Физика твёрдого тела",
                        BookAuthor = "Павлов П.В. Хохлов А.Ф.",
                        ShortDescription = "Физика твёрдого тела",
                        LongDescription = "Ноучно доказаные факты о повидении твёрдых тел",
                        Img = "/img/Phisick Hard Body.jpg",
                        Price = 244,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Наука"]
                    }
                    );
            }

            content.SaveChanges();
        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(_category == null)
                {
                    var list = new Category[]
                    {
                        new Category{CategoryName = "Наука", Description="Научно достоверный метериал"},
                        new Category{CategoryName = "Художественная литература", Description="Истории, рассказы и многое другое"},
                        new Category{CategoryName = "Программирование", Description="Руководство по программированию"},
                        new Category{CategoryName = "Детектив", Description="Запутаные истории в которых, казалось бы нет решения"},
                        new Category{CategoryName = "Фантастика", Description="Выдуманый рассказ автором"}
                    };

                    _category = new Dictionary<string, Category>();

                    foreach (Category el in list)
                        _category.Add(el.CategoryName, el);
                }
                return _category;
            }
        }
    }
}
