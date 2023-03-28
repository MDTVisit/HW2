using System;

class Program {
    static void Main(string[] args) {
        double x, y;
        int numVertices = 0;
        double[] xCoords = new double[100]; 
        double[] yCoords = new double[100];
        do {
            x =  Convert.ToDouble(Console.ReadLine());
            y =  Convert.ToDouble(Console.ReadLine());
            if (x != 0 || y != 0) {
                xCoords[numVertices] = x;
                yCoords[numVertices] = y;
                numVertices++;
            }
        } while (x != 0 || y != 0);

        double pointX =  Convert.ToDouble(Console.ReadLine());
        double pointY =  Convert.ToDouble(Console.ReadLine());

        bool inside = false;
        for (int i = 0, j = numVertices - 1; i < numVertices; j = i++) {
            if (((yCoords[i] > pointY) != (yCoords[j] > pointY)) && (pointX < (xCoords[j] - xCoords[i]) * (pointY - yCoords[i]) / (yCoords[j] - yCoords[i]) + xCoords[i])) {
                inside = !inside;
            }
        }

        if (inside) {
            Console.WriteLine("Inside");
        } else {
            Console.WriteLine("Outside");
        }
    }
}
