// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Thailand.Identity;

public static class Military
{
	public static List<ArmyRank> Army =>
	[
		new("พลเอก", "General", "พล.อ.", "Gen"),
		new("พลโท", "Lieutenant General", "พล.ท.","Lt Gen"),
		new("พลตรี", "Major General", "พล.ต.","Maj Gen"),
		new("พันเอก", "Colonel", "พ.อ.","Col"),
		new("พันโท", "Lieutenant Colonel", "พ.ท.","Lt Col"),
		new("พันตรี", "Major", "พ.ต.","Maj"),
		new("ร้อยเอก", "Captain", "ร.อ.","Capt"),
		new("ร้อยโท", "First Lieutenant", "ร.ท.","1st Lt"),
		new("ร้อยตรี", "Second Lieutenant", "ร.ต.","2nd Lt"),
		new("นักเรียนนายร้อย", "Officer Cadet", "นนร.","Cadet"),
		new("จ่าสิบเอกพิเศษ", "Sergeant Major 1st Class (Special)", "จ.ส.อ.(พ)","Sgt Maj 1st (Sp)"),
		new("จ่าสิบเอก", "Sergeant Major 1st Class", "จ.ส.อ.","Sgt Maj 1st"),
		new("จ่าสิบโท", "Sergeant Major 2nd Class", "จ.ส.ท.","Sgt Maj 2nd"),
		new("จ่าสิบตรี", "Sergeant Major 3rd Class", "จ.ส.ต.","Sgt Maj 3rd"),
		new("สิบเอก", "Sergeant", "ส.อ.","Sgt"),
		new("สิบโท", "Corporal", "ส.ท.","Cpl"),
		new("สิบตรี", "Lance Corporal", "ส.ต.","L/Cpl"),
		new("พลทหาร", "Private", "พลฯ","Ptv"),
	];

	public static List<NavyRank> Navy => [
		new("พลเรือเอก", "Admiral", "พล.ร.อ.","Adm"),
		new("พลเรือโท", "Vice Admiral", "พล.ร.ท.","Vice Adm"),
		new("พลเรือตรี", "Rear Admiral", "พล.ร.ต.","Rear Adm"),
		new("นาวาเอก", "Captain", "น.อ.","Capt"),
		new("นาวาโท", "Commander", "น.ท.","Cdr"),
		new("นาวาตรี", "Lieutenant Commander", "น.ต.","Lt Cdr"),
		new("เรือเอก", "Lieutenant", "ร.อ.","Lt"),
		new("เรือโท", "Lieutenant Junior", "ร.ท.","Lt Jnr"),
		new("เรือตรี", "Sub Lieutenant", "ร.ต.","Sub Lt"),
		new("นักเรียนนายเรือ", "Midshipman", "นนร.","Msm"),
		new("พันจ่าเอกพิเศษ", "Chief Petty Officer 1st Class (Special)", "พ.จ.อ.(พ)","CPO 1st (Sp)"),
		new("พันจ่าเอก", "Chief Petty Officer 1st Class", "พ.จ.อ.","CPO 1st"),
		new("พันจ่าโท", "Chief Petty Officer 2nd Class", "พ.จ.ท.","CPO 2nd"),
		new("พันจ่าตรี", "Chief Petty Officer 3rd Class", "พ.จ.ต.","CPO 3rd"),
		new("จ่าเอก", "Petty Officer 1st Class", "จ.อ.","PO 1st"),
		new("จ่าโท", "Petty Officer 2nd Class", "จ.ท.","PO 2nd"),
		new("จ่าตรี", "Petty Officer 3rd Class", "จ.ต.","PO 3rd"),
		new("พลทหารเรือ", "Seaman", "พลฯ ร.","Sm"),
	];

	public static List<AirForceRank> AirForce => [
		new("พลอากาศเอก", "Air Chief Marshal", "พล.อ.อ.","ACM"),
		new("พลอากาศโท", "Air Marshal", "พล.อ.ท.","AM"),
		new("พลอากาศตรี", "Air Vice Marshal", "พล.อ.ต.","AVM"),
		new("นาวาอากาศเอก", "Group Captain", "น.อ.","Gp Capt"),
		new("นาวาอากาศโท", "Wing Commander", "น.ท.","Wg Cdr"),
		new("นาวาอากาศตรี", "Squadron Leader", "น.ต.","Sqn Ldr"),
		new("เรืออากาศเอก", "Flight Lieutenant", "ร.อ.","Flt Lt"),
		new("เรืออากาศโท", "Flying Officer", "ร.ท.","Flt Off"),
		new("เรืออากาศตรี", "Pilot Officer", "ร.ต.","P/O"),
		new("นักเรียนนายเรืออากาศ", "Air Cadet", "นนอ.","Cadet"),
		new("พันจ่าอากาศเอกพิเศษ", "Fight Sergeant 1st (Special)", "พ.อ.อ.(พ)","Flt Sgt 1st (Sp)"),
		new("พันจ่าอากาศเอก", "Flight Sergeant 1st", "พ.อ.อ.","Flt Sgt 1st"),
		new("พันจ่าอากาศโท", "Flight Sergeant 2nd", "พ.อ.ท.","Flt Sgt 2nd"),
		new("พันจ่าอากาศตรี", "Flight Sergeant 3rd", "พ.อ.ต.","Flt Sgt 3rd"),
		new("จ่าอากาศเอก", "Sergeant", "จ.อ.","Sgt"),
		new("จ่าอากาศโท", "Corporal", "จ.ท.","Cpl"),
		new("จ่าอากาศตรี", "Leading Aircraftman", "จ.ต.","LAC"),
		new("พลทหารอากาศ", "Aircraftman", "พลฯ อ.","ACM"),
	];

	public static List<PoliceRank> Police => [
		new("พลตำรวจเอก", "Police General", "พล.ต.อ.","Pol Gen"),
		new("พลตำรวจโท", "Police Lieutenant General", "พล.ต.ท.","Pol Lt Gen"),
		new("พลตำรวจตรี", "Police Major General", "พล.ต.ต.","Pol Maj Gen"),
		new("พันตำรวจเอก", "Police Colonel", "พ.ต.อ.","Pol Col"),
		new("พันตำรวจโท", "Police Lieutenant Colonel", "พ.ต.ท.","Pol Lt Col"),
		new("พันตำรวจตรี", "Police Major", "พ.ต.ต.","Pol Maj"),
		new("ร้อยตำรวจเอก", "Police Captain", "ร.ต.อ.","Pol Capt"),
		new("ร้อยตำรวจโท", "Police Lieutenant", "ร.ต.ท.","Pol Lt"),
		new("ร้อยตำรวจตรี", "Police Sub Lieutenant", "ร.ต.ต.","Pol Sub Lt"),
		new("นักเรียนนายร้อยตำรวจ", "Police Cadet", "นรต.","Pol Cadet"),
		new("ดาบตำรวจ", "Police Senior Sergeant Major", "ด.ต.","Pol Snr Sgt Maj"),
		new("จ่าสิบตำรวจ", "Police Sergeant Major", "จ.ส.ต.","Pol Sgt Maj"),
		new("สิบตำรวจเอก", "Police Sergeant", "ส.ต.อ.","Pol Sgt"),
		new("สิบตำรวจโท", "Police Corporal", "ส.ต.ท.","Pol Cpl"),
		new("สิบตำรวจตรี", "Police Lance Corporal", "ส.ต.ต.","Pol L/Cpl"),
		new("พลตำรวจ", "Police Constable", "พลฯ ต.","Pol Const"),
	];
}
