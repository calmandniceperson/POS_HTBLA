{:logging {:loggers [{:type :stdout :level :debug}
                     ;; {:type :remote :host "beast.local" :level :debug}
                     ;; {:type :file :file "caribou-logging.out" :level :debug}
                     ]}
 :app {:use-database true}
 :cljs {:root "resources/cljs"
        :reload false
        :options {:output-to "resources/public/js/app/httptest.js"
                  :optimizations :whitespace
                  :pretty-print true}}
 :database {:classname    "org.h2.Driver"
            :subprotocol  "h2"
            :protocol     "file"
            :path         "./"
            :database     "httptest_development"
            :host         "localhost"
            :subname      "file:httptest_development"
            :user         "h2"
            :password     ""}
 :controller {:namespace "httptest.controllers" :reload :always}
 :nrepl {:port 44444}
 :cache-templates :never}
