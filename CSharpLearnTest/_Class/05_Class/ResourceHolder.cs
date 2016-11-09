using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._05_Class {
	class ResourceHolder:IDisposable {
		private bool isDisposed = false;//表示对象是否已被清理，确保不重复清理，同时确保只有一个线程调用该方法

		/// <summary>
		/// IDisposable接口提供了一种机制，允许类的用户控制资源释放的时间，通过调用Dispose()方法
		/// </summary>
		public void Dispose() {
			Dispose(true);	//bool参数表明清理工作是由用户调用Dispose()方法执行的
			GC.SuppressFinalize(this);	//告诉垃圾回收器 该类不再需要调用析构函数了
		}


		/*
		 * 托管资源：像简单的int,string,float,DateTime等等，.net中超过80%的资源都是托管资源
		 * 
		 * -------------------------------------------------------------------------
		 * 
		 * 非托管资源：包装操作系统资源的对象，例如文件，窗口或网络连接，对于这类资源
		 * 虽然垃圾回收器可以跟踪封装非托管资源的对象的生存期，但它不了解具体如何清理这些资源。还好
		 * .net Framework提供了Finalize()方法，它允许在垃圾回收器回收该类资源时，适当的清理非托管资源。
		 */


		protected virtual void Dispose(bool disposing) {
			if (!isDisposed) {
				
				if (disposing) {
					//By Calling Dispose()
					//To do 清理托管的对象
					Console.WriteLine("Cleanup 托管对象");
					// ect.
				}

				//To do清理非托管的对象
				Console.WriteLine(("Cleanup 非托管对象"));
				// ect.
			}
			isDisposed = true;
		}

		/// <summary>
		/// 析构函数 由垃圾回收器调用 执行时间不确定 且需执行两次 还需开辟另一线程执行Finalize()方法
		/// </summary>
		~ResourceHolder() {
			Dispose(false);

			/*  析构函数的IL代码
			protected override void Finalize()
			{
				try{
					Dispose(false);
				}
				finally{
					base.Finalize();
				}
			}
			*/
		}

		public void SomeMethod() {
			if (isDisposed) {
				throw new ObjectDisposedException("ResourceHolder");
			}
		}
	}
}
