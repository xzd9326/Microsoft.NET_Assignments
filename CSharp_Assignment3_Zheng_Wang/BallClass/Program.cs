using ColloredBall;

Ball ball0 = new Ball(0, 1, new Color(5, 10, 20));
Ball ball1 = new Ball(1, 2, new Color(45, 70, 10));
Ball ball2 = new Ball(2, 4, new Color(59, 60, 12));
Ball ball3 = new Ball(3, 16, new Color(255, 24, 98));
Ball ball4 = new Ball(4, 99, new Color(99, 8, 77));
Ball ball5 = new Ball(5, 128, new Color(69, 126, 183));

Console.WriteLine($"This ball has grayscale {ball0.Color.GetGrayscale()}");
ball0.Throw();
ball1.Throw();
ball2.Throw();
ball3.Throw();
ball4.Throw();
ball0.Throw();
ball0.Throw();
ball1.Throw();
ball2.Throw();
ball4.Pop();
ball5.Pop();
ball1.Throw();
ball2.Throw();
ball3.Throw();
ball4.Throw();
ball5.Throw();

Console.WriteLine("Each ball have been thrown:");
Console.WriteLine(ball0.BeenThrown());
Console.WriteLine(ball1.BeenThrown());
Console.WriteLine(ball2.BeenThrown());
Console.WriteLine(ball3.BeenThrown());
Console.WriteLine(ball4.BeenThrown());
Console.WriteLine(ball5.BeenThrown());
Console.WriteLine("times");
