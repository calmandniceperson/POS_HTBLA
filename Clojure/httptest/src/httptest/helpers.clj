(ns httptest.helpers)

(def additional-helpers
  {:hello 
   (fn [x] 
     (str "Hello " x "!"))})
