    using System;
    
    public struct Size 
    {
		    private double m_width;
		    private double m_height;
 
        public Size(double width, double height) 
        {
            if (width < 0 || height < 0) 
            { 
                throw new System.ArgumentException("negative argument");
            } 
            m_width = width;
            m_height = height;
        } 
 
        public double Width 
        {
            get => m_width;
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("negative argument"); 
                }  
                m_width = value; 
            }
        } 
 
        public double Height
        { 
            get
            {
                return m_height; 
            }
            set
            {  
                if (value < 0) 
                {
                    throw new System.ArgumentException("negative argument");
                } 
                m_height = value;
            } 
        } 
    } 
    class A3
    {
        static void Main(string[] args)
        {
            Size size1=new Size(0,0);
            try {
                size1.Height=-1;
            }
            catch(System.ArgumentException e){
                System.Console.WriteLine(e.Message);
            }

        }
    }
