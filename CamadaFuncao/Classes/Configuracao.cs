using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CamadaFuncao.Cls
{
    public class Configuracao
    {
        #region [Propriedades]

        
        public bool Local { get; set; }

        public bool Rede { get; set; }

        public string Servidor { get; set; }

        public string CaminhoBanco { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        #endregion

        #region [Métodos]

        /// <summary>
        /// Configura os caminhos do banco
        /// </summary>
        /// <param name="pConfiguracao"></param>
        public void GravarArquivoConfiguracao(Configuracao pConfiguracao)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Configuracao));

            if (File.Exists("..\\Config.xml"))
                File.Delete("..\\Config.xml");

            StreamWriter file = new StreamWriter("..\\Config.xml");
            writer.Serialize(file, pConfiguracao);
            file.Close();
        }

        public Configuracao CarregarArquivoConfiguracao()
        {
            
            Configuracao oConfiguracao = null;
            if (File.Exists("..\\Config.xml"))
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Configuracao));
                FileStream fs = new FileStream("..\\Config.xml", FileMode.Open);
                XmlReader reader = XmlReader.Create(fs);

                oConfiguracao = (Configuracao)serializer.Deserialize(reader);
                reader.Close();
            }

            return oConfiguracao;
        }

        #endregion
    }
}
