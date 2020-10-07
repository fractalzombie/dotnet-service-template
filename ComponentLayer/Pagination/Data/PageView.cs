using System;
using System.Collections.Generic;

namespace ComponentLayer.Pagination.Data
{
    public readonly struct PageView
    {
        private static readonly Random Random = new Random();
        public int Number { get; }
        public PageType Type { get; }

        public PageView(int number, PageType type)
        {
            Number = number;
            Type = type;
        }

        public static PageView MakePrev()
        {
            return new PageView(Random.Next(), PageType.Prev);
        }

        public static PageView MakeNext()
        {
            return new PageView(Random.Next(), PageType.Next);
        }

        public static PageView MakeFirst()
        {
            return new PageView(1, PageType.Page);
        }

        public static PageView MakeLast(int lastPageNumber)
        {
            return new PageView(lastPageNumber, PageType.Page);
        }

        public static PageView MakeSeparator()
        {
            return new PageView(Random.Next(), PageType.Separator);
        }

        public static IEnumerable<PageView> MakeLeftSide()
        {
            return new List<PageView>
            {
                MakePrev(),
                MakeSeparator()
            };
        }

        public static IEnumerable<PageView> MakeRightSide()
        {
            return new List<PageView>
            {
                MakeSeparator(),
                MakeNext()
            };
        }
    }
}
