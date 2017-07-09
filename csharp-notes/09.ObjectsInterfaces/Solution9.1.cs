namespace _09.ObjectsInterfaces
{


    //PART 1
    abstract class Renderer
    {
        public string Body;

        abstract public string FormatBody();

        public void Render()
        {
            System.Console.WriteLine(FormatBody());
        }
    }

    class HtmlRenderer : Renderer
    {
        public override string FormatBody()
        {
            return $"<html><p>{Body}</p></html>";
        }
    }

    class TextRenderer : Renderer
    {
        public override string FormatBody()
        {
            return $"-----\n {Body}\n -----\n";
        }
    }


	//PART 2
	interface IRenderable
	{
		string FormatBody();
		void Render();
	}

	class ConsoleRenderer : IRenderable
    {
		public string Body;

		public virtual string FormatBody()
		{
			return Body;
		}

		public void Render()
		{
			System.Console.WriteLine(FormatBody());
		}

	}

	class HtmlConsoleRenderer : ConsoleRenderer
	{

		public override string FormatBody()
		{
			return $"<p>{Body}</p>";
		}
	}

    class TextConsoleRenderer : ConsoleRenderer
    {

        public override string FormatBody()
        {
            return $"-----\n {Body}\n -----\n";
        }
    }
    class Solution9_1
    {
        public static void Solution()
        {

            //PART 1
            Renderer[] rds = {
             new HtmlRenderer { Body = "Message" },
             new TextRenderer { Body = "Another Message" }
            };


            foreach (var renderer in rds)
            {
                renderer.Render();
            }


            //PART 2
            IRenderable[] irds = {
                 new HtmlConsoleRenderer { Body = "Message" },
                 new TextConsoleRenderer { Body = "Another Message"}
             };
        }
    }
}