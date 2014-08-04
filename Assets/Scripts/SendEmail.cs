using UnityEngine;
using System.Collections;
using System;
using System.Net; 
using System.Net.Mail; 
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class SendEmail : MonoBehaviour {

	private int count = 0;
	
	void OnClick()
	{
		count++;
		send_email_with_attachment();

		/*     Nope!
		//Create the .txt file
		StreamWriter fileWriter = null;
		string fileName = Application.persistentDataPath + "/" + "test"+count.ToString()+".txt";
		fileWriter = File.CreateText(fileName);
		fileWriter.WriteLine("Hello world");
		fileWriter.Close();
		Application.OpenURL("mailto:?subject=subject&body=bodytesting&Attachment="+fileName); */

	}


	

	void send_email_no_attachment()
	{
		//This Works! But no Attachment :(
		string email = "me@example.com";
		string subject = MyEscapeURL("My Subject");
		string body = MyEscapeURL("My Body\r\nFull of non-escaped chars");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
		
	}

	string MyEscapeURL (string url)
	{
		return WWW.EscapeURL(url).Replace("+","%20");
	}

	void send_email_with_attachment()
	{

		//Initial MailMessage Info
		MailMessage mail = new MailMessage();
		mail.From = new MailAddress("burnknee.ramirez@gmail.com");
		mail.To.Add("burnknee.ramirez@gmail.com");
		mail.Subject = "Test Mail";
		mail.Body = "This is for testing SMTP mail from GMAIL";

		//Create the .txt file
		StreamWriter fileWriter = null;
		string fileName = Application.persistentDataPath + "/" + "test"+count.ToString()+".txt";
		fileWriter = File.CreateText(fileName);
		fileWriter.WriteLine("Hello world");
		fileWriter.Close();

		//Add the .txt file as an attachment
		mail.Attachments.Add (new System.Net.Mail.Attachment(fileName));


		//So some SMTP stuff
		SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
		smtpServer.Port = 587;
		smtpServer.Credentials = new System.Net.NetworkCredential("burnknee.ramirez@gmail.com", "%X8sbdbv") as ICredentialsByHost;
		smtpServer.EnableSsl = true;
		ServicePointManager.ServerCertificateValidationCallback = 
			delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) 
		{ return true; };
		smtpServer.Send(mail);
		Debug.Log("success");

	}


}



