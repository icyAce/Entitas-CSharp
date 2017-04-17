﻿using System.Collections.Generic;

namespace Entitas.Utils {

    public abstract class AbstractConfigurableConfig : IConfigurable {

        public abstract Dictionary<string, string> defaultProperties { get; }

        public Properties properties {
            get {
                if(_properties == null || _properties.count == 0) {
                    _properties = new Properties(defaultProperties);
                }

                return _properties;
            }
        }

        Properties _properties;

        public virtual void Configure(Properties properties) {
            _properties = properties;
            _properties.AddProperties(defaultProperties, false);
        }

        public override string ToString() {
            return properties.ToString();
        }
    }
}