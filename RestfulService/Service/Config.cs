using lingvo.tokenizing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulService.Service
{
    public class Config
    {
        public static readonly string URL_DETECTOR_RESOURCES_XML_FILENAME = "wwwroot/[resources]/url-detector-resources.xml";
        public static readonly string SENT_SPLITTER_RESOURCES_XML_FILENAME = "wwwroot/[resources]/sent-splitter-resources.xml";
        public static readonly string TOKENIZER_RESOURCES_XML_FILENAME = "wwwroot/[resources]/crfsuite-tokenizer-resources.xml";
        public static readonly string NER_MODEL_FILENAME = "wwwroot/[resources]/model_pa_(minfreq-1)_ru";
        public static readonly string NER_TEMPLATE_FILENAME = "wwwroot/[resources]/templateNER.txt";
        public static readonly LanguageTypeEnum LANGUAGE_TYPE = LanguageTypeEnum.Ru;

        public static readonly int MAX_INPUTTEXT_LENGTH = 10000;
        public static readonly int CONCURRENT_FACTORY_INSTANCE_COUNT = 2;
        public static readonly int SAME_IP_INTERVAL_REQUEST_IN_SECONDS = 10;
        public static readonly int SAME_IP_MAX_REQUEST_IN_INTERVAL = 3;
        public static readonly int SAME_IP_BANNED_INTERVAL_IN_SECONDS = 120;
    }
}
