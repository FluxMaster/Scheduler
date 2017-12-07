import java.util.*;
import java.io.*;

public class Generator
{
	public static void main(String[] args) throws IOException
	{
		int num =Integer.parseInt(args[0]);
		System.out.println(num);
		for(int z=0; z<num; z++)
		{
			Random r = new Random();
			int n = r.nextInt(5163);
			
			Scanner nameFinder = new Scanner(new File ("Names.txt"));
			String name = "";
			
			while(n > 0 && nameFinder.hasNextLine())
			{
				name = nameFinder.nextLine();
				n--;
			}
			name = name.substring(0,name.indexOf(" "));
			int room = (r.nextInt(6)*100+r.nextInt(21));
			
			FileWriter fw = new FileWriter("PeopleSchedules/"+(name+"_"+String.valueOf(room)+".csv"));
			
			fw.write("Name:,"+name+"\n");
			fw.write("Employee ID:,"+room+"\n");
			fw.write("\n");
			fw.write("Schedule,Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday\n");
			for(int i = 0; i < 24; i++)
			{
				fw.write(i+"-"+(i+1));
				for(int j = 0; j<7 ; j++)
				{
					fw.write(",");
					if(r.nextInt(2)==1)
					{
						fw.write("x");
					}				
				}
				fw.write(",");
				fw.write("\n");
			}
			fw.close();
		}
	}
}