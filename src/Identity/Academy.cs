// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Thailand.Identity;

public static class Academy
{
	public static List<ProfessorRank> Professor =>
	[
		new("ศาสตราจารย์", "Professor", "ศ.", "Prof."),
		new("ผู้ช่วยศาสตราจารย์", "Assistant Professor", "ผศ.", "Asst. Prof."),
		new("รองศาสตราจารย์", "Associate Professor", "รศ.", "Assoc. Prof."),
		new("ศาสตราจารย์วุฒิคุณ", "Adjunct Professor", "ศ.ว.", "Adj. Prof."),
		new("ศาสตราจารย์เกียรติคุณ", "Professor Emeritus", "ศ.เกียรติคุณ", "Prof. Emeritus"),
	];

	public static List<EducationRank> Education =>
	[
		new("อนุบาล", "Kindergarten", "อ.", "K."),
		new("ประถมศึกษา", "Primary School", "ปใ", "P.S."),
		new("มัธยมต้น", "Secondary School", "ม.ต.", "S.S."),
		new("มัธยมปลาย", "High School", "ม.ปล.", "H.S."),
		new("ประกาศนียบัตรวิชาชีพ", "Vocational Certificate", "ปวช.", "Voc.Cert."),
		new("ประกาศนียบัตรวิชาชีพชั้นสูง", "Vocational Diploma", "ปวส.", "Voc.Dip."),
		new("อนุปริญญา", "Associate Degree", "อนุปริญญา", "A.D."),
		new("ปริญญาตรี", "Bachelor of Science", "วิทยาศาสตรบัณฑิต", "B.Sc."),
		new("ปริญญาโท", "Master of Science", "มหาบัณฑิต", "M.Sc."),
		new("ปริญญาเอก", "Doctor of Philosophy", "ดุษฎีบัณฑิต", "Ph.D."),
	];
}
