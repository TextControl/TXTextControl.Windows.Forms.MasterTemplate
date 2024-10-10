using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TXTextControl
{
    public class TemplateHandling
    {
        public static void ApplyTemplate(byte[] template, TextControl textControl)
        {
            using (ServerTextControl tx = new ServerTextControl())
            {
                tx.Create();
                tx.Load(template, BinaryStreamType.InternalUnicodeFormat);

                // Copy the paragraph and inline styles from the template to the target TextControl
                foreach (ParagraphStyle style in tx.ParagraphStyles)
                {
                    var existingStyle = textControl.ParagraphStyles.GetItem(style.Name);

                    if (existingStyle == null)
                    {
                        textControl.ParagraphStyles.Add(new ParagraphStyle(style));
                    }
                    else if (style.Name != "[Normal]")
                    {
                        CopyProperties(style, existingStyle);
                        existingStyle.Apply();
                    }
                }

                foreach (InlineStyle style in tx.InlineStyles)
                {
                    var existingStyle = textControl.InlineStyles.GetItem(style.Name);

                    if (existingStyle == null)
                    {
                        textControl.InlineStyles.Add(new InlineStyle(style));
                    }
                    else
                    {
                        CopyProperties(style, existingStyle);
                        existingStyle.Apply();
                    }
                }

            }
        }

        private static void CopyProperties(object source, object target)
        {
            if (source == null || target == null)
                throw new ArgumentNullException("Source or target object is null.");

            Type type = source.GetType();

            // Ensure both objects are of the same type
            if (type != target.GetType())
                throw new ArgumentException("Source and target must be of the same type.");

            // Get all public properties of the type
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                // Check if the property is writable
                if (property.CanWrite)
                {
                    object value = property.GetValue(source, null);

                    if (value != null && IsComplexType(property.PropertyType))
                    {
                        // If the property is a class and not a primitive or string, recursively copy
                        object targetValue = property.GetValue(target, null) ?? Activator.CreateInstance(property.PropertyType);
                        CopyProperties(value, targetValue);
                        property.SetValue(target, targetValue);
                    }
                    else
                    {
                        try
                        {
                            // Copy the value to the target object
                            property.SetValue(target, value);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }

        // Helper method to determine if a type is complex (i.e., not primitive, not string, not value type)
        private static bool IsComplexType(Type type)
        {
            return type.IsClass && type != typeof(string);
        }
    }
}
