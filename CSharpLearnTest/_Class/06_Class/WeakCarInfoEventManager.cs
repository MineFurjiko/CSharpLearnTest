﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSharpLearnTest._Class._06_Class {
	class WeakCarInfoEventManager:WeakEventManager {
		public static WeakCarInfoEventManager CurrentManager {
			get {
				WeakCarInfoEventManager manager = 
					GetCurrentManager(typeof(WeakCarInfoEventManager)) 
					as WeakCarInfoEventManager;
				if (manager==null) {
					manager = new WeakCarInfoEventManager();
					SetCurrentManager(typeof(WeakCarInfoEventManager), manager);
				}
				return manager;
			}
		}

		public static void AddListener(object source, IWeakEventListener listener) {
			CurrentManager.ProtectedAddListener(source,listener);
		}

		public static void RemoveListener(object source, IWeakEventListener listener) {
			CurrentManager.ProtectedRemoveListener(source, listener);
		}

		protected override void StartListening(object source) {
			(source as CarDealer).NewCarInfo += CarDealer_NewCarInfo;
		}

		private void CarDealer_NewCarInfo(object sender, CarInfoEventArgs e) {
			DeliverEvent(sender,e);
		}

		protected override void StopListening(object source) {
			(source as CarDealer).NewCarInfo -= CarDealer_NewCarInfo;
		}
	}
}
