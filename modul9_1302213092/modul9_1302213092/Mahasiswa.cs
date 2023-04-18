using System;
namespace modul9_1302213092;

public class mahasiswa
{
	public string nama { get; set; }
	public string nim { get; set; }
    public List<string> course { get; set; }
	public int year { get; set; }

	public mahasiswa(string nama, string nim, List<String> course, int year)
	{
		this.nama = nama;
		this.nim = nim;	
		this.course = course;
		this.year = year;
	}

}
