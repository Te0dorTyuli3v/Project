namespace Driver__Route__Delivery_ScheduleProject
{
	public class DeliverySchedule
	{
		public int DeliveryScheduleId { get; set; }
		public int DriverId { get; set; }
		public int RouteId { get; set; }
		public DateTime ScheduleDate { get; set; }
		public string Status { get; set; }
	}
}
